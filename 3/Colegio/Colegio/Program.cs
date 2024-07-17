using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.Imprimir();
            alumno1.EsMayorEdad();
            Console.ReadKey();
        }
    
    }
}
