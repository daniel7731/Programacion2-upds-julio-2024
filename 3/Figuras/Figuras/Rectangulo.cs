using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(string nombre, double baseRectangulo, double alturaRectangulo) : base(nombre)
        {
            this.Base = baseRectangulo;
            this.Altura = alturaRectangulo;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
