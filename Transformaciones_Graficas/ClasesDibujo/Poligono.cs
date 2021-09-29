using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones_Graficas
{   
    class Poligono : Figura
    {
        
        private List<Point> puntosTrazo;

        public Poligono(Point A, Point B, Pen contorno, SolidBrush relleno) : base(A, B, contorno, relleno)
        {
            
        }

    }
}
