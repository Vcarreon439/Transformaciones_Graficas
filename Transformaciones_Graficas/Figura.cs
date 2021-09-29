using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformaciones_Graficas
{
    public class Figura
    {
        public int X1, X2, Y1, Y2;
        //public int heigth, width;
        public Pen contorno;
        public SolidBrush relleno;

        public Figura(Point A, Point B, Pen contorno, SolidBrush relleno)
        {
            X1 = A.X;
            Y1 = A.Y;
            X2 = B.X;
            Y2 = B.Y;
            this.contorno = contorno;
            this.relleno = relleno;
        }

    }
}
