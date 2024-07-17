using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(string nombre, double radio) : base(nombre)
        {
            this.Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }
}
