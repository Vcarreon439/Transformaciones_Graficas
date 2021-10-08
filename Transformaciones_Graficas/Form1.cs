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
using BezierControl;
using FontAwesome.Sharp;
using Transformaciones_Graficas.ClasesDibujo;

namespace Transformaciones_Graficas
{
    public partial class Form1 : Form
    {
        //Lista de figuras
        private List<Figura> listaFiguras;

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

        private BezierLine bezier;
        private PoligonLine poligon;

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
                Mover,
                Rotar,
                Dibujando,
                Bezier,
                Redimensionar,
                Sesgado
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

        private float angulo = 0;
        private void btnRotar_Click(object sender, EventArgs e)
        {
            herramienta = EstadoDelPrograma.Herramienta.Rotar;

            if (lista.isStart)
            {
                canva.Clear(Color.White);
                Dibujado.RotateRectangle(ref canva, AuxFigura, angulo);
                Dibujado.DibujarAnteriores(canva, lista);
                Log($"{AuxFigura.TipoDFigura} rotada {angulo}, {AuxFigura.OriginPoint}, E{AuxFigura.EndPoint}");
            }
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
            if (herramienta == EstadoDelPrograma.Herramienta.Bezier)
            {
                bezier.MouseUp(e);
            }

            if (herramienta == EstadoDelPrograma.Herramienta.Sesgado)
            {
                poligon.MouseUp(e);
            }

            if (herramienta == EstadoDelPrograma.Herramienta.Dibujando)
            {
                pres = false;
                //Agrega un boton al tabCapas
                AgregarCapa(AuxFigura);
                //Agrega mensaje al Log
                /////
                Log($"{AuxFigura.TipoDFigura} dibujada en ({AuxFigura.OriginPoint}), tamaño:({AuxFigura.FigSize})");
                //Agrega la figura a una lista donde se guardara para volver a ser dibujada
                lista.AgregarFigura(AuxFigura);
                //Dibuja las figuras anteriores
                Dibujado.DibujarAnteriores(canva, lista);
            }

            if (lista.isStart)
            {
                Dibujado.DibujarAnteriores(canva, lista);
            }
        }

        private async void AgregarCapa(Figura fig)
        {


        }

        private bool pres = false;

        private void pnlFondo_MouseMove(object sender, MouseEventArgs e)
        {
            if (herramienta == EstadoDelPrograma.Herramienta.Bezier)
            {
                bezier.MouseMove(e);
            }

            if (herramienta == EstadoDelPrograma.Herramienta.Sesgado)
            {
                poligon.MouseMove(e);
            }

                

            //bezier.MouseMove(e);

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
            dibujo = EstadoDelPrograma.TipoDibujo.Circulo;
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            dibujo = EstadoDelPrograma.TipoDibujo.Rectangulo;
        }

        private void pnlFondo_MouseDown(object sender, MouseEventArgs e)
        {
            ////

            tmrUpdate.Stop();


            //Para el Poligono
            if (herramienta == EstadoDelPrograma.Herramienta.Sesgado)
            {
                if (!poligon.isStart)
                {
                    poligon.Spawn(pnlFondo.PointToClient(Cursor.Position).X, pnlFondo.PointToClient(Cursor.Position).Y);
                }

                poligon.MouseDown(e);
            }

            //Para el Bezier
            if (herramienta == EstadoDelPrograma.Herramienta.Bezier)
            {
                if (!bezier.isStart)
                {
                    bezier.Spawn(pnlFondo.PointToClient(Cursor.Position).X, pnlFondo.PointToClient(Cursor.Position).Y);
                }

                bezier.MouseDown(e);
            }


            
            orginPoint = pnlFondo.PointToClient(Cursor.Position);
            pres = true;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            listaFiguras = new List<Figura>();


            bezier = new BezierLine(pnlFondo);
            poligon = new PoligonLine(pnlFondo);
            

            bezier.ShowAnchors = true;
            bezier.ShowControls = true;

            poligon.ShowAnchors = true;
            poligon.ShowControls = true;

            canva = pnlFondo.CreateGraphics();
            DoubleBuffered = true;
            tmrUpdate.Start();
        }

        private void btnPoligono_Click(object sender, EventArgs e)
        {
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

        private int lados;
        private void txtLadosPoligono_TextChanged(object sender, EventArgs e)
        {
            if (txtLadosPoligono.TextBox.Text=="")
                return;

            lados = int.Parse(txtLadosPoligono.TextBox.Text);
        }

        private void txtAnguloFig_TextChanged(object sender, EventArgs e)
        {
            if(txtAnguloFig.TextBox.Text=="")
                return;

            angulo = float.Parse(txtAnguloFig.TextBox.Text);
        }

        private void pnlFondo_Paint(object sender, PaintEventArgs e)
        {
            if (herramienta == EstadoDelPrograma.Herramienta.Bezier)
            {
                bezier.Draw(e);
            }

            if (herramienta == EstadoDelPrograma.Herramienta.Sesgado)
            {
                poligon.Draw(e);
            }

        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            bezier.pathPenColor = btnContorno.BackColor;
            herramienta = EstadoDelPrograma.Herramienta.Bezier;
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            herramienta = EstadoDelPrograma.Herramienta.Mover;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            herramienta = EstadoDelPrograma.Herramienta.Dibujando;
        }

        private void pnlFondo_MouseEnter(object sender, EventArgs e)
        {
            if (herramienta == EstadoDelPrograma.Herramienta.Bezier)
                bezier.Enter(e);

            if (herramienta == EstadoDelPrograma.Herramienta.Sesgado)
                poligon.Enter(e);
        }

        private void pnlFondo_MouseLeave(object sender, EventArgs e)
        {
            if (herramienta == EstadoDelPrograma.Herramienta.Bezier)
                bezier.Leave(e);

            if (herramienta == EstadoDelPrograma.Herramienta.Sesgado)
                poligon.Leave(e);
        }

        private void btnRezise_Click(object sender, EventArgs e)
        {
            herramienta = EstadoDelPrograma.Herramienta.Redimensionar;
        }

        private void btnSesgado_Click(object sender, EventArgs e)
        {
            poligon.pathPenColor = btnContorno.BackColor;
            herramienta = EstadoDelPrograma.Herramienta.Sesgado;
        }
    }
}
