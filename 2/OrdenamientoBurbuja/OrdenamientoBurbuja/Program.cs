using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoBurbuja
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
            Console.WriteLine();
        }
        public static int[] ordenamenamientoBurbuja(int[] arr)
        {
            int temp;
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            return arr;
        }
        public static int BusquedaLineal(int[] lista, int elementoBuscado)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == elementoBuscado)
                {
                    return i; // Elemento encontrado en la posición i
                }
            }

            return -1; // Elemento no encontrado
        }
        static void Main(string[] args)
        {
            Console.Write("Ingresa el tamano del vector :");
            try
            {
                int n = int.Parse(Console.ReadLine());
                n = Math.Abs(n);
                int[] arreglo = crearArregloConDatosAleatorios(n, 1, 1000);
                Console.WriteLine("Datos generados");
                imprimirArreglo(arreglo);
                ordenamenamientoBurbuja(arreglo);
                Console.WriteLine("Datos ordenados");
                imprimirArreglo(arreglo);
                Console.WriteLine("Presiona una tecla para seguir");
                Console.ReadKey();
                Console.WriteLine("Buscar número");
                Console.WriteLine("Ingresa el número a buscar :");
                int num = int.Parse (Console.ReadLine());
                int posicion =  BusquedaLineal(arreglo, num);
                Console.WriteLine("El número " + num + " se encuentra en la posición :" + posicion);
                Console.ReadKey();
            }
            catch(Exception ex)
            {

            }
            
        }
    }
}
