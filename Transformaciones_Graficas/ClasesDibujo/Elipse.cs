using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones_Graficas
{
    public class Elipse : Figura
    {
        public Elipse(Point origin, Point end) : base(origin, end)
        {
        }

        public Elipse(Point origin, Point end, Pen contorno) : base(origin, end, contorno)
        {
        }

        public Elipse(Point origin, Point end, SolidBrush relleno) : base(origin, end, relleno)
        {
        }

        public Elipse(Point origin, Point end, Pen contorno, SolidBrush relleno) : base(origin, end, contorno, relleno)
        {
        }
    }
}
