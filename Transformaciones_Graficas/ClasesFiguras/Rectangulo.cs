using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Transformaciones_Graficas.ClasesDibujo
{
    public class Rectangulo : Figura
    {
        public Rectangulo(Figura fig) : base(fig)
        {
            this.Angulo = fig.Angulo;
            this.TipoDFigura = TipodeFigura.Rectangulo;
        }

        public Rectangulo(Point origin, Point end) : base(origin, end)
        {
            this.TipoDFigura = TipodeFigura.Rectangulo;
            Comprobacion();
        }

        public Rectangulo(Point origin, Point end, Pen contorno) : base(origin, end, contorno)
        {
            this.TipoDFigura = TipodeFigura.Rectangulo;
            Comprobacion();
        }

        public Rectangulo(Point origin, Point end, SolidBrush relleno) : base(origin, end, relleno)
        {
            this.TipoDFigura = TipodeFigura.Rectangulo;
            Comprobacion();
        }

        public Rectangulo(Point origin, Point end, Pen contorno, SolidBrush relleno) : base(origin, end, contorno, relleno)
        {
            this.TipoDFigura = TipodeFigura.Rectangulo;
            Comprobacion();
        }
    }
}
