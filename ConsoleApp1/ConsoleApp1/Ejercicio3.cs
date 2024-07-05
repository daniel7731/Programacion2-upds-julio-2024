using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio3
    {
        public static void calcular(string[] args)
        {
            int nu1, nu2, nu3;
            Console.WriteLine("Ingrese el primer numero");
            nu1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            nu2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            nu3 = int.Parse(Console.ReadLine());
            if (nu1 > nu2 && nu1 > nu3)
            {
                Console.WriteLine("El numero " + nu1 + " es mayor");
            }
            else if (nu2 > nu1 && nu2 > nu3)
            {
                Console.WriteLine("El numero " + nu2 + " es mayor");
            }
            else
            {

                Console.WriteLine("El numero " + nu3 + " es mayor");
            }
            /*# Console.ReadKey();*/
        }
    }
}
