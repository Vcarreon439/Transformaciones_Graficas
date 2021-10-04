using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using Rectangle = System.Drawing.Rectangle;

namespace Transformaciones_Graficas
{
    /// <summary>
    /// Clase encargada de definir el area donde se plasmaran las figuras
    /// </summary>
    public class Figura
    {

        #region Enum para tipo de figura
        /// <summary>
        /// Sirve para identificar el tipo de figura segun cada clase heredada
        /// </summary>
        public enum TipodeFigura
        {
            Elipse,
            Rectangulo,
            Poligono,
            Estrella
        }

        #endregion

        #region PrivateProperties

        private int cantVertices;

        private float _angulo;

        //Propiedad para identificar a la figura
        private string _identificador;

        //Puntos para region de area cuadrada
        private Point originPoint;
        private Point endPoint;

        //Tamaño de la figura en base a posisciones
        private Size figSize;

        //Variables para contorno y rellenos
        private Pen _contourPen;
        private SolidBrush _fillBrush;
        
        //Variable para identificar el tipo de figura al cual se refiere
        private TipodeFigura tipoDFigura;

        #endregion

        #region Constructors

        public Figura(Figura fig)
        {
            OriginPoint = fig.OriginPoint;
            EndPoint = fig.EndPoint;
            Comprobacion();
            this.figSize = calcularSize();
            this.ContourPen = fig.ContourPen;
            this._fillBrush = fig._fillBrush;
        }

        /// <summary>
        /// Constructor en caso de no tener un relleno o un contorno
        /// </summary>
        /// <param name="origin">Punto de origen</param>
        /// <param name="end">Punto donde termina el area</param>
        public Figura(Point origin, Point end)
        {
            OriginPoint = origin;
            EndPoint = end;
            Comprobacion();
            this.figSize = calcularSize();
            this.ContourPen = new Pen(Color.Black, 1);
            this._fillBrush = new SolidBrush(Color.Transparent);
        }

        /// <summary>
        /// Constructor en caso de tener un contorno
        /// </summary>
        /// <param name="origin">Punto de origen</param>
        /// <param name="end">Punto donde termina el area</param>
        /// <param name="contorno">Parametro para contorno de la figura</param>
        public Figura(Point origin, Point end, Pen contorno)
        {
            OriginPoint = origin;
            EndPoint = end;
            Comprobacion();
            this.figSize = calcularSize();
            this.ContourPen = contorno;
            this._fillBrush = new SolidBrush(Color.Transparent);
        }

        /// <summary>
        /// Constructor en caso de tener un relleno
        /// </summary>
        /// <param name="origin">Punto de Origen</param>
        /// <param name="end">Punto donde termina el area</param>
        /// <param name="relleno">Parametro para relleno de la figura</param>
        public Figura(Point origin, Point end, SolidBrush relleno)
        {
            OriginPoint = origin;
            EndPoint = end;
            Comprobacion();
            this.figSize = calcularSize();
            this.ContourPen = new Pen(Color.Transparent, 0);
            this._fillBrush = relleno;
        }

        /// <summary>
        /// Constructor en caso de tener contorno y relleno
        /// </summary>
        /// <param name="origin">Puntor de Origen</param>
        /// <param name="end">Punto donde termina el area</param>
        /// <param name="contorno">Parametro para el contorno de la figura</param>
        /// <param name="relleno">Parametro para el relleno de la figura</param>
        public Figura(Point origin, Point end, Pen contorno, SolidBrush relleno)
        {
            OriginPoint = origin;
            EndPoint = end;
            Comprobacion();
            this.figSize = calcularSize();
            this.ContourPen = contorno;
            this.FillBrush = relleno;
        }

        #endregion

        #region GetterSetters
        public Point OriginPoint
        {
            get => originPoint;
            set => originPoint = value;
        }
        public Point EndPoint
        {
            get => endPoint;
            set => endPoint = value;
        }

        public Size FigSize
        {
            get => figSize;
            set => figSize = value;
        }

        public Pen ContourPen
        {
            get => _contourPen;
            set => _contourPen = value;
        }

        public SolidBrush FillBrush
        {
            get => _fillBrush;
            set => _fillBrush = value;
        }

        public TipodeFigura TipoDFigura
        {
            get => tipoDFigura;
            set => tipoDFigura = value;
        }

        public string Identificador
        {
            get => _identificador;
            set => _identificador = value;
        }

        public float Angulo
        {
            get => _angulo;
            set => _angulo = value;
        }

        public int CantVertices
        {
            get => cantVertices;
            set => cantVertices = value;
        }

        #endregion

        #region InternalMethods

        /// <summary>
        /// </summary>
        /// <returns>El tamaño del area donde se esta trabajando</returns>
        internal Size calcularSize()
        {
            return new Size(endPoint.X-OriginPoint.X, endPoint.Y-OriginPoint.Y);
        }


        /// <summary>
        /// Metodo para poder crear la figura hacia cualquier direccion
        /// </summary>
        internal void Comprobacion()
        {
            if (this.EndPoint.X < this.OriginPoint.X)
            {
                int x1 = OriginPoint.X, y1 = OriginPoint.Y, x2 = EndPoint.X, y2 = EndPoint.Y;
                this.OriginPoint = new Point(x2, y1);
                this.EndPoint = new Point(x1, y2);
            }

            if (this.EndPoint.Y < this.OriginPoint.Y)
            {
                int x1 = OriginPoint.X, y1 = OriginPoint.Y, x2 = EndPoint.X, y2 = EndPoint.Y;
                this.OriginPoint = new Point(x1, y2);
                this.EndPoint = new Point(x2, y1);
            }
        }

        #endregion

        ~Figura()
        {
        }
    }
}
