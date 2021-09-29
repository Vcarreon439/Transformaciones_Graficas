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

namespace Transformaciones_Graficas
{
    public enum EstadoHerramienta
    {
        Ninguno,
        Seleccionar,
        Mover,
        Rotar,
        DibujandoCirculo,
        DibujandoRectangulo
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
                    DibujarCirculo(trazo);
                    break;

                case EstadoHerramienta.DibujandoRectangulo:
                    DibujarRectangulo(trazo);
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

        private void DibujarCirculo(Figura circuloFigura)
        {
            Rectangle fig = new Rectangle(circuloFigura.X1, circuloFigura.Y1, (circuloFigura.X2 - circuloFigura.X1), (circuloFigura.Y2 - circuloFigura.Y1));
            canva.FillEllipse(circuloFigura.relleno, fig);
            canva.DrawEllipse(circuloFigura.contorno, fig);
        }
        
        private void DibujarRectangulo(Figura circuloFigura)
        {
            Rectangle fig = new Rectangle(circuloFigura.X1, circuloFigura.Y1, (circuloFigura.X2 - circuloFigura.X1), (circuloFigura.Y2 - circuloFigura.Y1));
            canva.FillRectangle(circuloFigura.relleno, fig);
            canva.DrawRectangle(circuloFigura.contorno, fig);
        }

        private int x1, y1;
        private int x2, y2;

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
                x2 = pnlFondo.PointToClient(Cursor.Position).X;
                y2 = pnlFondo.PointToClient(Cursor.Position).Y;
                Figura fig = new Figura(new Point(x1,y1),new Point(x2,y2), new Pen(Color.Black,1), new SolidBrush(Color.White));
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

        private void pnlFondo_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = pnlFondo.PointToClient(Cursor.Position).X; 
            y1 = pnlFondo.PointToClient(Cursor.Position).Y;
            pres = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canva = pnlFondo.CreateGraphics();
        }
    }
}
