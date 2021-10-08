using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Transformaciones_Graficas.ClasesDibujo
{
    public class Dibujado
    {
        static public void Transladar(Graphics lienzo, Figura figura, float X, float Y)
        {
            figura.OriginPoint = new Point();
        }


        static public void RotateRectangle(ref Graphics lienzo, Figura fig, float angle)
        {
            fig.Angulo = angle;

            Rectangle nuevo = new Rectangle(fig.OriginPoint, fig.FigSize);

            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(nuevo.Left + (nuevo.Width / 2), nuevo.Top + (nuevo.Height / 2)));
                lienzo.Transform = m;

                switch (fig.TipoDFigura)
                {
                    case(Figura.TipodeFigura.Elipse):
                        lienzo.DrawEllipse(fig.ContourPen, nuevo);
                        lienzo.FillEllipse(fig.FillBrush, nuevo);
                        break;
                        
                    case(Figura.TipodeFigura.Rectangulo):
                        lienzo.DrawRectangle(fig.ContourPen, nuevo);
                        lienzo.FillRectangle(fig.FillBrush, nuevo);
                        break;

                    case (Figura.TipodeFigura.Poligono):
                        Poligono pol = Poligono.ConvertShapeToPoligon(fig, fig.CantVertices);
                        DibujarPoligono(lienzo, pol);
                        break;
                }
                
                lienzo.ResetTransform();
            }
        }

        static public void RotatePoligon(ref Poligono poligono, double angulo)
        {
            for (int i = 0; i < poligono.Vertices.Count; i++)
            {
                poligono.Vertices[i] = rotatePoint(poligono.Vertices[i], new PointF(poligono.EndPoint.X, poligono.EndPoint.Y), angulo);
            }

        }

        static public PointF rotatePoint(PointF point, PointF centroid, double angle)
        {
            float x = centroid.X + (int)((point.X - centroid.X) * Math.Cos(angle) - (point.Y - centroid.Y) * Math.Sin(angle));
            float y = centroid.Y + (int)((point.X - centroid.X) * Math.Sin(angle) + (point.Y - centroid.Y) * Math.Cos(angle));

            return new PointF(x, y);
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
                            if (var.Angulo != 0)
                            {
                                Dibujado.RotateRectangle(ref lienzo, var, var.Angulo);
                            }
                            else
                            {
                                Rectangulo aaRectangulo = new Rectangulo(var);
                                DibujarRectangulo(ref lienzo, aaRectangulo);
                            }

                            break;

                        case (Figura.TipodeFigura.Elipse):
                            if (var.Angulo != 0)
                            {
                                Dibujado.RotateRectangle(ref lienzo, var, var.Angulo);
                            }
                            else
                            {
                                Elipse aaElipse = new Elipse(var);
                                DibujarCirculo(lienzo, aaElipse);
                            }
                            break;
                        
                        case (Figura.TipodeFigura.Poligono):
                            if (var.Angulo!=0)
                            {
                                Dibujado.RotateRectangle(ref lienzo, var, var.Angulo);
                            }
                            else
                            {
                                ////////////////
                                //No esta recibiendo el poligono con el arreglo vartices
                                //Poligono aaPoligono = new Poligono(var);
                                Poligono aaPoligono = Poligono.ConvertShapeToPoligon(var, var.CantVertices);
                                DibujarPoligono(lienzo, aaPoligono);
                            }
                            break;

                        case (Figura.TipodeFigura.Estrella):
                            break;
                    }
                }
            }
        }


        static public void DibujarCirculo(Graphics lienzo, Elipse figura)
        {
            Rectangle fig = new Rectangle(figura.OriginPoint.X, figura.OriginPoint.Y, figura.FigSize.Width, figura.FigSize.Height);
            lienzo.FillEllipse(figura.FillBrush, fig);
            lienzo.DrawEllipse(figura.ContourPen, fig);
            //return figura;
        }

        static public void DibujarRectangulo(ref Graphics lienzo, Rectangulo rectangulo)
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
    }
}
