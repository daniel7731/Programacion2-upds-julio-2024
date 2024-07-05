using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /**
     * 1.- La jornada de trabajo es de 48 horas, calcular dada las horas trabajadas  
     * con el valor por hora. Mostrar su salario y las horas extras si se excede de la jornada.
     */
    public class Ejercicio1 { 
     public static void calcular(string[] args)
    {
        int h, v, salario = 0;
        int jornada = 48;
        string nombre;
        Console.WriteLine("Ingresar el nombre del trabajador");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingresar la cantidad de horas trabajadas");
        h = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar el valor por hora trabajada");
        v = int.Parse(Console.ReadLine());
        salario = h * v;
        Console.WriteLine("El salario del trabajador;");
        Console.WriteLine(nombre + " es " + salario + "\n");
        Console.WriteLine("La jornada es de : " + jornada + " horas");
        int he = h - jornada;
        if (h > jornada)
        {
            Console.WriteLine("Tiene " + he + " horas extras");
        }
        else
        {
            Console.WriteLine("No tiene horas extras");
        }
            /*# Console.ReadKey();*/
        }
    }
}
