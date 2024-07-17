using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Figura
    {
        public string Nombre { get; set; }

        public Figura(string nombre)
        {
            this.Nombre = nombre;
        }

        public virtual double CalcularArea()
        {
            throw new NotImplementedException();
        }
    }
}
