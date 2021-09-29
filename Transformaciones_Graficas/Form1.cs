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
    public enum EstadoHerramienta
    {
        Ninguno,
        Seleccionar,
        Mover,
        Rotar,
        DibujandoCirculo,
        DibujandoRectangulo,
        DibPoligono
    }

    public partial class Form1 : Form
    {
        private Graphics canva;

        private EstadoHerramienta estado = EstadoHerramienta.Ninguno;

        public Form1()
        {
            InitializeComponent();
        }

        private void ComprobarMenuDer()
        {

        }

        private void Dibujar(Figura trazo)
        {
            switch (estado)
            {
                case EstadoHerramienta.Ninguno:
                    break;

                case EstadoHerramienta.Seleccionar:
                    break;

                case EstadoHerramienta.Mover:
                    break;

                case EstadoHerramienta.Rotar:
                    break;

                case EstadoHerramienta.DibujandoCirculo:
                    DibujarCirculo(new Elipse(orginPoint, endPoint));
                    break;

                case EstadoHerramienta.DibPoligono:
                    Dibujado dibujo = new Dibujado(canva);
                    Poligono obj = new Poligono(orginPoint, endPoint, 4);
                    Dibujado.DrawStar(canva, obj);
                    DibujarRectangulo(new Rectangulo(orginPoint, endPoint));
                    break;

                case EstadoHerramienta.DibujandoRectangulo:
                    DibujarRectangulo(new Rectangulo(orginPoint, endPoint));
                    break;
            }
        }


        //Global for menu der
        private int width;

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

        private void DibujarRectangulo(Pen contorno, Brush relleno, Point A, Point B)
        {
            Rectangle fig = new Rectangle(A.X, A.Y, (B.X - A.X), (B.Y - A.Y));
            canva.FillRectangle(relleno, fig);
            canva.DrawRectangle(contorno, fig);
        }

        private void DibujarCirculo(Elipse figura)
        {
            Rectangle fig = new Rectangle(figura.OriginPoint.X, figura.OriginPoint.Y, figura.FigSize.Width, figura.FigSize.Height);
            canva.FillEllipse(figura.FillBrush, fig);
            canva.DrawEllipse(figura.ContourPen, fig);
        }
        
        private void DibujarRectangulo(Rectangulo rectangulo)
        {
            Rectangle fig = new Rectangle(rectangulo.OriginPoint.X, rectangulo.OriginPoint.Y, rectangulo.FigSize.Width, rectangulo.FigSize.Height);
            canva.FillRectangle(rectangulo.FillBrush, fig);
            canva.DrawRectangle(rectangulo.ContourPen, fig);
        }

        private Point orginPoint;
        private Point endPoint;

        private void pnlFondo_MouseUp(object sender, MouseEventArgs e)
        {
            pres = false;
        }

        private bool pres = false;
        private void pnlFondo_MouseMove(object sender, MouseEventArgs e)
        {
            if (pres==false)
            {

            }
            else
            {
                canva.Clear(Color.White);
                endPoint = GetMousePostion();
                Figura fig = new Figura(orginPoint,endPoint, new Pen(Color.Black,1), new SolidBrush(Color.White));
                Dibujar(fig);
            }
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {

        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            estado = EstadoHerramienta.DibujandoCirculo;
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            estado = EstadoHerramienta.DibujandoRectangulo;
        }

        private Point GetMousePostion()
        {
            return PointToClient(Cursor.Position);
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
            estado = EstadoHerramienta.DibPoligono;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            canva = pnlFondo.CreateGraphics();
            canva.Clear(Color.White);
        }

        protected override void WndProc(ref Message m)
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
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            //canva = pnlFondo.CreateGraphics();
            //canva.Clear(Color.White);
        }
    }
}
