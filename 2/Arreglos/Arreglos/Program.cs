using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
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
            
            for(int index=0; index < arreglo.Length; index++)
            {
                arreglo[index] = random.Next(1,100);
            }
          
            return arreglo;
        }
        public static int[] crearArregloConDatosAleatorios(int dimension , int minimo,int maximo)
        {
            Random random = new Random();
            int[] arreglo = new int[dimension];
            for (int index = 0; index < arreglo.Length; index++)
            {
                arreglo[index] = random.Next(minimo,maximo);
            }
            return arreglo;
        }
        public static void imprimirArreglo(int[] arreglo)
        {
            Console.Write("[");
            for(int index=0; index < arreglo.Length; index++)
            {
                Console.Write(arreglo[index]);
                if ( index +1 < arreglo.Length)
                {
                    Console.Write(',');
                }
            }
            Console.Write("]");
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Arreglos");
            Console.WriteLine("Ingresa a la dimensin del arreglo");
            try
            {
                string linea = Console.ReadLine();
                int dim = int.Parse(linea);
                dim = Math.Abs(dim);
                if ( dim > 0)
                {
                    int[] arreglos = crearArregloConDatosAleatorios(dim);
                    imprimirArreglo(arreglos);
                }
                else
                {
                    Console.WriteLine("Porfavor ingresa un numero mayor a 0");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Presiona una tecla para finalizar");
            
            ConsoleKeyInfo key = Console.ReadKey();
           
            
        }
    }
}
