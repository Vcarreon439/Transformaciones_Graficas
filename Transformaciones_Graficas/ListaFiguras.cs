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
        public List<Figura> enCanva;

        public ListaFiguras()
        {
            enCanva = new List<Figura>();
        }

        public void AgregarFigura(Figura figura)
        {
            enCanva.Add(figura);
        }

        public void QuitarFigura(Figura figura)
        {
            enCanva.Remove(figura);
        }

    }
}
