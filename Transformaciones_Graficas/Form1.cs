using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private Point GetMousePostion()
        {
            return PointToClient(Cursor.Position);
        }

        /*protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0112) // WM_SYSCOMMAND
            {
                // Check your window state here
                if (m.WParam == new IntPtr(0xF030)) // Maximize event - SC_MAXIMIZE from Winuser.h
                {
                    canva = pnlFondo.CreateGraphics();
                    canva.Clear(Color.White);
                }
            }
            base.WndProc(ref m);
        }*/

        private void ComprobarMenuDer()
        {

        }
        private void Log(string mensaje)
        {
            txtLog.Text += $"{mensaje}" + Environment.NewLine;
        }

        private void Dibujar(ref Figura trazo)
        {
            this.contorno = new Pen(btnContorno.BackColor);
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
                    Poligono poli = new Poligono(trazo.OriginPoint, trazo.EndPoint, contorno, rellenoBrush);
                    Dibujado.DibujarPoligono(canva, poli);
                    trazo.TipoDFigura = Figura.TipodeFigura.Poligono;
                    trazo = poli;
                    break;

                case EstadoDelPrograma.TipoDibujo.Rectangulo:
                    Rectangulo rect = new Rectangulo(trazo.OriginPoint, trazo.EndPoint, contorno, rellenoBrush);
                    Dibujado.DibujarRectangulo(canva, rect);
                    trazo.TipoDFigura = Figura.TipodeFigura.Rectangulo;
                    trazo = rect;
                    break;
            }
        }

        #endregion

        #region Eventos del Programa

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



        private void pnlFondo_MouseUp(object sender, MouseEventArgs e)
        {
            pres = false;
            Log($"Figura: {AuxFigura.TipoDFigura} dibujada en Start:{AuxFigura.OriginPoint}, End:{AuxFigura.EndPoint}");
            lista.AgregarFigura(AuxFigura);

            Dibujado.DibujarAnteriores(canva, lista);

        }

        private bool pres = false;
        private void pnlFondo_MouseMove(object sender, MouseEventArgs e)
        {
            if (pres == false)
            {

            }
            else
            {
                if (herramienta == EstadoDelPrograma.Herramienta.Dibujando)
                {
                    canva.Clear(Color.White);
                    endPoint = GetMousePostion();
                    Figura fig = new Figura(orginPoint, endPoint);
                    Dibujar(ref fig);
                    AuxFigura = fig;
                }
            }
        }



        private void tmrUpdate_Tick(object sender, EventArgs e)
        {

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
            orginPoint = GetMousePostion();
            pres = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canva = pnlFondo.CreateGraphics();
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
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            //canva = pnlFondo.CreateGraphics();
            //canva.Clear(Color.White);
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

        private void btnContorno_CheckStateChanged(object sender, EventArgs e)
        {
            btnContorno.BackColor = Color.Yellow;
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            Dibujado.RotateRectangle(canva, lista.enCanva[0],45);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tabCapas.AutoScroll = true;
            CButton boton = new CButton(tabCapas);
            tabCapas.Controls.Add(boton);
            boton.BringToFront();
        }
    }
}
