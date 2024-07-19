using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVectores
{
    internal class Program
    {
        public static int[] crearArreglo(int dimension)
        {
            int[] arreglo = new int[dimension];
            return arreglo;
        }
        public static int[] crearArregloConDatosAleatorios(int dimension)
        {
            Random random = new Random();
            int[] arreglo = new int[dimension];

            for (int index = 0; index < arreglo.Length; index++)
            {
                arreglo[index] = random.Next(1, 100);
            }

            return arreglo;
        }
        public static int[] crearArregloConDatosAleatorios(int dimension, int minimo, int maximo)
        {
            Random random = new Random();
            int[] arreglo = new int[dimension];
            for (int index = 0; index < arreglo.Length; index++)
            {
                arreglo[index] = random.Next(minimo, maximo);
            }
            return arreglo;
        }
        public static void imprimirArreglo(int[] arreglo)
        {
            Console.Write("[");
            for (int index = 0; index < arreglo.Length; index++)
            {
                Console.Write(arreglo[index]);
                if (index + 1 < arreglo.Length)
                {
                    Console.Write(',');
                }
            }
            Console.Write("]");
        }
        public static int[] vectorA()
        {
            int[] a = { 2, 7, 6, 5, 4, 11, 18, 23, 2, 7, 18 };
            return a;
        }
        public static int[] vectorB()
        {
            int[] a = { 12, 17, 6, 5, 4, 31, 18, 23, 2, 7, 18 };
            return a;
        }
        public static int[] vectorizar(int n) {
            //tu codigo va aqui
            return null;
        }
        public static int [] interseccion(int[] arreglo1 , int [] arreglo2) {
            // tu codigo va aqui
            return null;
        }
        public static int  mayorFrecuencia(int[] arreglo)
        {
            //tu codigo va aqui.
            return 0;
        }
        static void Main(string[] args)
        {

        }
    }
}
