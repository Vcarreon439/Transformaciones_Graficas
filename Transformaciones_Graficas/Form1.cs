using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Transformaciones_Graficas.ClasesDibujo;

namespace Transformaciones_Graficas
{
    public partial class Form1 : Form
    {
        #region VariablesDeControl
        //Lista que contendra las figuras a dibujar
        private ListaFiguras lista = new ListaFiguras();
        //Area de dibujo
        private Graphics canva;
        //Variables de control de estado del programa
        private EstadoDelPrograma.Herramienta herramienta;
        private EstadoDelPrograma.TipoDibujo dibujo;
        //Variables para el relleno y contorno de la figura dibujada
        private Pen contorno;
        private SolidBrush rellenoBrush;
        //Figura auxiliar para ser almacenada en lista(ListaFiguras)
        public Figura AuxFigura;
        //Variable para en tamaño del menu derecho
        private int width;
        //Variables de control para el origen y final de la figura dibujada
        private Point orginPoint;
        private Point endPoint;
        #endregion

        #region EnumEstado del Programa

        /// <summary>
        /// Es para el control de las Herramientas del programa
        /// </summary>
        internal class EstadoDelPrograma
        {
            public enum Herramienta
            {
                Ninguno,
                Seleccionar,
                Mover,
                Rotar,
                Dibujando
            }

            public enum TipoDibujo
            {
                Ninguno,
                Rectangulo,
                Circulo,
                Poligono
            }
        }

        #endregion

        #region Metodos propios de la clase

        private void Log(string mensaje)
        {
            txtLog.Text += $"{mensaje}" + Environment.NewLine;
        }

        /// <summary>
        /// Dibuja determinada figura en el canva principal
        /// </summary>
        /// <param name="trazo">Figura la cual se plasmara en el canva principal</param>
        private void Dibujar(ref Figura trazo)
        {
            //Contorno de la figura
            this.contorno = new Pen(btnContorno.BackColor);
            //Relleno de la figura
            this.rellenoBrush = new SolidBrush(btnRelleno.BackColor);

            switch (dibujo)
            {
                case EstadoDelPrograma.TipoDibujo.Circulo:
                    Elipse elips = new Elipse(trazo.OriginPoint, trazo.EndPoint, contorno, rellenoBrush);
                    Dibujado.DibujarCirculo(canva, elips);
                    trazo = elips;
                    break;
                ////
                case EstadoDelPrograma.TipoDibujo.Poligono:
                    Poligono poli = new Poligono(trazo.OriginPoint, trazo.EndPoint, contorno, rellenoBrush, lados);
                    Dibujado.DibujarPoligono(canva, poli);
                    trazo.TipoDFigura = Figura.TipodeFigura.Poligono;
                    trazo = poli;
                    break;

                case EstadoDelPrograma.TipoDibujo.Rectangulo:
                    Rectangulo rect = new Rectangulo(trazo.OriginPoint, trazo.EndPoint, contorno, rellenoBrush);
                    Dibujado.DibujarRectangulo(ref canva, rect);
                    trazo.TipoDFigura = Figura.TipodeFigura.Rectangulo;
                    trazo = rect;
                    break;
            }
        }

        #endregion

        #region Eventos del Programa
        private void btnRotar_Click(object sender, EventArgs e)
        {
            canva.Clear(Color.White);
            Dibujado.RotateRectangle(ref canva,AuxFigura, 45);
            Dibujado.DibujarAnteriores(canva, lista);
            Log($"{AuxFigura.TipoDFigura} rotada {45}, {AuxFigura.OriginPoint}, E{AuxFigura.EndPoint}");
        }

        private void icnPctShHi2_Click(object sender, EventArgs e)
        {
            if (tabInfo.Visible == false)
            {
                tabInfo.Show();
                pnlMenuDer.Size = new Size(width, pnlMenuDer.Size.Height);
                icnPctShHi2.IconChar = IconChar.AngleDoubleRight;
            }
            else
            {
                tabInfo.Hide();
                width = pnlMenuDer.Size.Width;
                pnlMenuDer.Size = new Size(33, pnlMenuDer.Size.Height);
                icnPctShHi2.IconChar = IconChar.AngleDoubleLeft;
            }
        }


        private void PnlFondo_MouseUp(object sender, MouseEventArgs e)
        {
            pres = false;
            //Agrega un boton al tabCapas
            AgregarCapa(AuxFigura);    
            //Agrega mensaje al Log
            Log($"{AuxFigura.TipoDFigura} dibujada en ({AuxFigura.OriginPoint}), tamaño:({AuxFigura.FigSize})");
            //Agrega la figura a una lista donde se guardara para volver a ser dibujada
            lista.AgregarFigura(AuxFigura);
            //Dibuja las figuras anteriores
            Dibujado.DibujarAnteriores(canva, lista);
        }

        private async void AgregarCapa(Figura fig)
        {


        }

        private bool pres = false;

        private void pnlFondo_MouseMove(object sender, MouseEventArgs e)
        {
            if (pres && herramienta == EstadoDelPrograma.Herramienta.Dibujando)
            {
                canva.Clear(Color.White);
                endPoint = pnlFondo.PointToClient(MousePosition); ;
                Figura fig = new Figura(orginPoint, endPoint);
                Dibujar(ref fig);
                AuxFigura = fig;
                AuxFigura.Identificador = $"{AuxFigura.TipoDFigura} {lista.enCanva.Count}";
            }
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            herramienta = EstadoDelPrograma.Herramienta.Dibujando;
            dibujo = EstadoDelPrograma.TipoDibujo.Circulo;
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            herramienta = EstadoDelPrograma.Herramienta.Dibujando;
            dibujo = EstadoDelPrograma.TipoDibujo.Rectangulo;
        }

        private void pnlFondo_MouseDown(object sender, MouseEventArgs e)
        {
            orginPoint = pnlFondo.PointToClient(Cursor.Position);
            pres = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canva = pnlFondo.CreateGraphics();
            DoubleBuffered = true;
            tmrUpdate.Start();
        }

        private void btnPoligono_Click(object sender, EventArgs e)
        {
            herramienta = EstadoDelPrograma.Herramienta.Dibujando;
            dibujo = EstadoDelPrograma.TipoDibujo.Poligono;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            canva = pnlFondo.CreateGraphics();
            canva.Clear(Color.White);
            Dibujado.DibujarAnteriores(canva, lista);
        }

        private void btnContorno_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                btnContorno.BackColor = clr.Color;
            }
        }

        private void btnRelleno_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                btnRelleno.BackColor = clr.Color;
            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnExportLog_Click(object sender, EventArgs e)
        {
            string folderName = @"Logs/";
            // If directory does not exist, create it
            if (!Directory.Exists(folderName))
                Directory.CreateDirectory(folderName);

            File.WriteAllText($"Logs/{DateTime.Today.Day}-{DateTime.Today.Month}-{DateTime.Today.Year}.txt",txtLog.Text);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private int lados;
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            lados = int.Parse(toolStripTextBox1.TextBox.Text);
        }
    }
}
