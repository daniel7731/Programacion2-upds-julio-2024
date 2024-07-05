using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios;
namespace ConsoleApp1
{
    internal class Program
    {
        public Boolean esPar(int numero)
        {

           return numero % 2 == 0;
        }
        public Boolean esPrimo( int numero)
        {
            return false;
        }
        public Boolean esMutiplo6(int numero) { 
        
            return false;
        }
        public int mayorEntre3Numeros(int numero) { 
        
            return 0;
        }
        public int mayorEntre4Numeros (int numero)
        {
            return 0;
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            int x = 5;
            Boolean si = p.esPar(x);
            System.Console.WriteLine(x);
            if ( si)
            {
                Console.WriteLine("Es Par");
            }
            else {

                Console.WriteLine("Es impar");
            }
            while(true)
            {
                Console.WriteLine("finalizar? S/N");
                string comando = Console.ReadLine();
                if (comando == "S")
                    break;
                Ejercicios.Ejercicio1.calcular(args);
                Ejercicios.Ejercicio2.calcular(args);
                Ejercicios.Ejercicio3.calcular(args);
            }
        }
    }
}
