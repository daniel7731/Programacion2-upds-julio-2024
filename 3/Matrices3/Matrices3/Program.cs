using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices3
{
    public class Matriz
    {
        private int[,] mat;
        public int filas { get; }
        public int columnas { get; }
        public Matriz(int filas, int columnas)
        {
            this.filas = Math.Abs(filas);
            this.columnas = Math.Abs(columnas);
            mat = new int[filas, columnas];
        }
        public void CargarAleatorio(int minimo, int maximo)
        {
            Random random = new Random();
            for (int f = 0; f < this.filas; f++)
            {
                for (int c = 0; c < this.columnas; c++)
                {


                    mat[f, c] = random.Next(minimo, maximo);
                }
            }
        }
        public void setElemento(int fila, int columna , int elemento) {
            mat[fila, columna] = elemento;
        }
        public int getElemento(int fila , int columna)
        {
            return mat[fila, columna];
        }
        public bool esMatrizDiagonal() {

           // Asumimos que la matriz es cuadrada
            if ( columnas != filas)
                return false;

            int n = this.columnas;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Si un elemento fuera de la diagonal principal es diferente de cero,
                    // entonces la matriz no es diagonal
                    if (i != j && getElemento(i, j) != 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public bool esMatrizIdentidad() { return true; }
        public bool esMatrizEscalar() { return true; }
        public Matriz getTranspuesta() {
            int filas = this.columnas;
            int columnas = this.filas;

            // Crear una matriz transpuesta con dimensiones intercambiadas
            Matriz m2 = new Matriz(filas, columnas);

            // Llenar la matriz transpuesta intercambiando filas y columnas
            for (int i = 0; i < this.filas; i++)
            {
                for (int j = 0; j < this.columnas; j++)
                {
                    int e = this.getElemento(i, j);
                    m2.setElemento(j,i,e);
                }
            }

            // Imprimir la matriz transpuesta (opcional)
            return m2;
        }

        public void Imprimir()
        {
            for (int f = 0; f < this.filas; f++)
            {
                for (int c = 0; c < this.columnas; c++)
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
                Console.WriteLine("Ingresa el numero de columnas :");
                int columnas = int.Parse(Console.ReadLine());
                Matriz m = new Matriz(filas, columnas);
                m.CargarAleatorio(1, 10);
                m.Imprimir();
                Matriz m2 = m.getTranspuesta();
                Console.WriteLine("Transpuesta");
                m2.Imprimir();
                Boolean diagonal = m2.esMatrizDiagonal();
                Console.WriteLine($"la matriz es digonal? {diagonal}");
            }
            catch (Exception e)
            {
    
            }
            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();

        }

    }
}
