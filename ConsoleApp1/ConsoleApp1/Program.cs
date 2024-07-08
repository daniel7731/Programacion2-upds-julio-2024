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
            if (numero <= 1)
            {
                return false;
            }
            else if (numero <= 3)
            {
                return true;
            }
            else if (numero % 2 == 0)
            {
                return false;
            }

            // Check for odd divisors from 3 to sqrt(number)
            int i = 3;
            while (i * i <= numero)
            {
                if (numero % i == 0)
                {
                    return false;
                }

                i += 2;
            }

            return true;
        }
        public Boolean esMutiplo6(int numero) { 
        
            return numero % 6 == 0;
        }
        public int mayorEntre3Numeros(int numero1, int numero2, int numero3 ) {

            int mayor = numero1;

            if (numero2 > mayor)
            {
                mayor = numero2;
            }

            if (numero3 > mayor)
            {
                mayor = numero3;
            }

            return mayor;
        }
        public int mayorEntre4Numeros (int numero1, int numero2, int numero3 , int numero4)
        {
            return 0;
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            
            while(true)
            {
                Console.WriteLine("¡Bienvenido al programa de utilidades!");
                Console.WriteLine("Elige una de las siguientes opciones:\r\n\r\n 1.Determinar si un número es primo.\r\n 2.Determinar si un número es par.\r\n 3.Determinar si un número es múltiplo de 6.\r\n 4.Encontrar el número mayor entre tres números.\r\n 5.Encontrar el número mayor entre cuatro números.");

             
                try
                {
                    string comando1 = Console.ReadLine();
                    if (comando1.Equals("2"))
                    {
                        Console.WriteLine("Ingresa un número");
                        int num = int.Parse( Console.ReadLine());
                        Boolean bandera = p.esPar(num);
                        if ( bandera)
                            Console.WriteLine("El número " + num +" es par");
                        else
                            Console.WriteLine("El número " + num + " no es par");
                    }
                    if (comando1.Equals("3"))
                    {
                        Console.WriteLine("Ingresa un número");
                        int num = int.Parse(Console.ReadLine());
                        Boolean bandera = p.esMutiplo6(num);
                        if (bandera)
                            Console.WriteLine("El número " + num + " es multiplo de 6");
                        else
                            Console.WriteLine("El número " + num + " no es multiplo de 6");
                    }
                    if (comando1.Equals("1"))
                    {
                        Console.WriteLine("Ingresa un número");
                        int num = int.Parse(Console.ReadLine());
                        Boolean bandera = p.esPrimo(num);
                        if (bandera)
                            Console.WriteLine("El número " + num + " es primo");
                        else
                            Console.WriteLine("El número " + num + " no es primo");
                    }
                    if (comando1.Equals("4"))
                    {
                        Console.WriteLine("Ingresa el primer número");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo número");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el tercero número");
                        int num3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el tercero número");
                        int mayor = p.mayorEntre3Numeros(num1, num2, num3);
                        Console.WriteLine("El número " + mayor + " es el mayor entre ("+num1+','+num2+','+num3+")");
                    }
                    if (comando1.Equals("5"))
                    {
                        Console.WriteLine("Ingresa el primer número");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo número");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el tercero número");
                        int num3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el cuarto número");
                        int num4 = int.Parse(Console.ReadLine());
                        int mayor = p.mayorEntre4Numeros(num1,num2, num3, num4);
                        Console.WriteLine("El número " + mayor + " es el mayor entre (" + num1 + ',' + num2 + ',' + num3 +","+num4 +")");
                    }

                    Console.WriteLine("Escribe S para finalizar");
                    string comando = Console.ReadLine();
                    comando = comando.Trim();
                    comando = comando.ToLower();
                    if ( comando.Equals("s")) {
                        break;
                    }
                }
                catch(Exception ex)
                {

                }

               
            }
        }
    }
}
