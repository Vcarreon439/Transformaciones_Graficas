using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformaciones_Graficas
{
    public class ListaFiguras
    {
        public bool isStart = false;

        public List<Figura> enCanva;

        public ListaFiguras()
        {
            enCanva = new List<Figura>();
        }

        public void AgregarFigura(Figura figura)
        {
            isStart = true;
            enCanva.Add(figura);
        }

        public void QuitarFigura(Figura figura)
        {
            enCanva.Remove(figura);
        }

        public int ObtenerIndice(Figura figura)
        {
            return enCanva.FindIndex(a => a.Identificador == figura.Identificador);
        }

    }
}
