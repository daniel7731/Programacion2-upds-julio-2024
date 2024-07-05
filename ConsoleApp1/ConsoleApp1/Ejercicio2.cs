using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /**
     *Determinar cuánto se debe pagar por una cantidad de lápices considerando que si son de 1000 o más,
     *existe un descuento de 7%,
     *teniendo en cuenta que el costo por lápiz es de S/. 2.50 ; de lo contrario no hay descuento.
     */
    public class Ejercicio2
    {
        public static void calcular(string[] args)
        {
            int cantidad;
            double costo, descuento, tpago;
            Console.WriteLine("Ingrese la cantidad de lapices comprados");
            cantidad = int.Parse(Console.ReadLine());
            costo = cantidad * 2.50;
            Console.WriteLine("Precio por lapiz : 2.50 \n");
            Console.WriteLine("El costo es; " + costo + "\n");
            if (cantidad > 1000)
            {
                Console.WriteLine("Descuento = 7% \n");
                descuento = costo * 0.07;
                Console.WriteLine(" es ===> " + descuento + "\n");
                tpago = costo - descuento;
                Console.WriteLine("El total a pagar es : " + tpago);
            }
            else
            {
                Console.WriteLine("No hay descuento ");
            }
            /*# Console.ReadKey();*/
        }
    }


}
