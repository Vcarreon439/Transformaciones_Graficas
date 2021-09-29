using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones_Graficas.ClasesDibujo
{
    public class Dibujado
    {
        private Graphics lienzo;

        public Graphics Lienzo
        {
            get => lienzo;
            set => lienzo = value;
        }

        public Dibujado(Graphics g)
        {
            this.lienzo = g;
        }

        public void RotateRectangle(Rectangle r, float angle)
        {
            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(r.Left + (r.Width / 2), r.Top + (r.Height / 2)));
                lienzo.Transform = m;
                lienzo.DrawRectangle(Pens.Black, r);
                lienzo.ResetTransform();
            }
        }


        private void DibujarCirculo(Elipse figura)
        {
            Rectangle fig = new Rectangle(figura.OriginPoint.X, figura.OriginPoint.Y, figura.FigSize.Width, figura.FigSize.Height);
            lienzo.FillEllipse(figura.FillBrush, fig);
            lienzo.DrawEllipse(figura.ContourPen, fig);
        }

        private void DibujarRectangulo(Rectangulo rectangulo)
        {
            Rectangle fig = new Rectangle(rectangulo.OriginPoint.X, rectangulo.OriginPoint.Y, rectangulo.FigSize.Width, rectangulo.FigSize.Height);
            lienzo.FillRectangle(rectangulo.FillBrush, fig);
            lienzo.DrawRectangle(rectangulo.ContourPen, fig);
        }

        // Draw the indicated star in the rectangle.
        static public void DrawStar(Graphics lienzo, Poligono poli)
        {
            Rectangle fig = new Rectangle(poli.OriginPoint.X, poli.OriginPoint.Y, poli.FigSize.Width, poli.FigSize.Height);
            PointF[] arreglo = poli.Vertices.ToArray();
            // Draw the star.
            lienzo.FillPolygon(poli.FillBrush, arreglo);
            lienzo.DrawPolygon(poli.ContourPen, arreglo);
        }

    }
}
