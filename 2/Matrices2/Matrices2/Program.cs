using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices2
{
    public class Matriz
    {
        private int[,] mat;
        public int filas { get;   }
        public int columnas { get; }
        public Matriz(int filas, int columnas)
        {
            this.filas = Math.Abs( filas);
            this.columnas = Math.Abs(columnas);
            mat = new int[filas, columnas];
        }
        public void CargarAleatorio(int minimo, int maximo)
        {
          Random random = new Random();
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
              
                   
                    mat[f, c] = random.Next(minimo,maximo);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine("");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresa el numero de filas :");
                int filas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el numero de filas :");
                int columnas = int.Parse(Console.ReadLine());
                Matriz m = new Matriz(filas, columnas);
                m.CargarAleatorio(1,10);
                m.Imprimir();
            }
            catch (Exception e){ 
            
            }
            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();

        }
       
    }
}
