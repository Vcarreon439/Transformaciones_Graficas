using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones_Graficas.ClasesDibujo
{
    public class Rectangulo : Figura
    {

        

        public Rectangulo(Point origin, Point end) : base(origin, end)
        {
            Comprobacion();
        }

        public Rectangulo(Point origin, Point end, Pen contorno) : base(origin, end, contorno)
        {
            Comprobacion();
        }

        public Rectangulo(Point origin, Point end, SolidBrush relleno) : base(origin, end, relleno)
        {
            Comprobacion();
        }

        public Rectangulo(Point origin, Point end, Pen contorno, SolidBrush relleno) : base(origin, end, contorno, relleno)
        {
            Comprobacion();
        }
    }
}
