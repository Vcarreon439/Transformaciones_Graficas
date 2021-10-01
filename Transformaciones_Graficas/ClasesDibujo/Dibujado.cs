using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones_Graficas.ClasesDibujo
{
    public class Dibujado
    {
        static public void Transladar(Graphics lienzo, Figura figura, float X, float Y)
        {
            figura.OriginPoint = new Point();
        }


        static public void RotateRectangle(Graphics lienzo, Figura fig, float angle)
        {
            Rectangle nuevo = new Rectangle(fig.OriginPoint, fig.FigSize);

            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(nuevo.Left + (nuevo.Width / 2), nuevo.Top + (nuevo.Height / 2)));
                lienzo.Transform = m;
                lienzo.DrawRectangle(fig.ContourPen, nuevo);
                lienzo.FillRectangle(fig.FillBrush, nuevo);
                lienzo.ResetTransform();
            }
        }

        static async public void DibujarAnteriores(Graphics lienzo, ListaFiguras lista)
        {
            if (lista.enCanva.Capacity != null)
            {
                foreach (Figura var in lista.enCanva)
                {
                    switch (var.TipoDFigura)
                    {
                        case (Figura.TipodeFigura.Rectangulo):
                            Rectangulo aaRectangulo = new Rectangulo(var);
                            DibujarRectangulo(lienzo, aaRectangulo);
                            break;
                        case (Figura.TipodeFigura.Elipse):
                            Elipse aaElipse = new Elipse(var);
                            DibujarCirculo(lienzo, aaElipse);
                            break;
                        
                        case (Figura.TipodeFigura.Poligono):
                            //No esta recibiendo el poligono con el arreglo vartices
                            //Poligono aaPoligono = new Poligono(var);
                            Poligono aaPoligono = Poligono.ConvertShapeToPoligon(var);
                            DibujarPoligono(lienzo, aaPoligono);
                            break;

                        case (Figura.TipodeFigura.Estrella):
                            break;
                    }
                }
            }
        }


        static public Elipse DibujarCirculo(Graphics lienzo, Elipse figura)
        {
            RectangleF fig = new RectangleF(figura.OriginPoint.X, figura.OriginPoint.Y, figura.FigSize.Width, figura.FigSize.Height);
            lienzo.FillEllipse(figura.FillBrush, fig);
            lienzo.DrawEllipse(figura.ContourPen, fig);
            return figura;
        }

        static public void DibujarRectangulo(Graphics lienzo, Rectangulo rectangulo)
        {
            Rectangle fig = new Rectangle(rectangulo.OriginPoint.X, rectangulo.OriginPoint.Y, rectangulo.FigSize.Width, rectangulo.FigSize.Height);
            lienzo.FillRectangle(rectangulo.FillBrush, fig);
            lienzo.DrawRectangle(rectangulo.ContourPen, fig);
        }

        // Draw the indicated star in the rectangle.
        static public void DibujarPoligono(Graphics lienzo, Poligono poli)
        {
            Rectangle fig = new Rectangle(poli.OriginPoint.X, poli.OriginPoint.Y, poli.FigSize.Width, poli.FigSize.Height);
            PointF[] arreglo = poli.Vertices.ToArray();
            // Draw the star.
            lienzo.FillPolygon(poli.FillBrush, arreglo);
            lienzo.DrawPolygon(poli.ContourPen, arreglo);
        }
        
        static public void DibujarPoligono(ref Figura aaFigura, Graphics lienzo, Poligono poli)
        {
            aaFigura = new Poligono(aaFigura);
            RectangleF fig = new RectangleF(poli.OriginPoint.X, poli.OriginPoint.Y, poli.FigSize.Width, poli.FigSize.Height);
            PointF[] arreglo = poli.Vertices.ToArray();
            // Draw the star.
            lienzo.FillPolygon(poli.FillBrush, arreglo);
            lienzo.DrawPolygon(poli.ContourPen, arreglo);
        }
    }
}
