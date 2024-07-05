using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio4
    {
        public static void calcular(string[] args){

            int n;
            string linea;
            Console.Write("Ingrese multiplicador: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (int i = 1; i <= 15; i++)
            {
                Console.Write(i + " x " + n + " = " + i * n + "\n");
            }
        }
    }
}
