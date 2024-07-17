using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo1 = new Circulo("Círculo1", 5);
            Rectangulo rectangulo1 = new Rectangulo("Rectángulo1", 10, 7);

            Console.WriteLine("Área del círculo "+circulo1.Nombre +": "+ circulo1.CalcularArea());
            Console.WriteLine("Área del rectángulo "+ rectangulo1.Nombre +": "+ rectangulo1.CalcularArea());
            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
