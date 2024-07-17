using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{
    public class Alumno
    {
        private string nombre;
        private int edad;

        public Alumno()
        {
            Console.Write("Ingrese nombre:");
            nombre = Console.ReadLine();
            Console.Write("Ingrese edad:");
            string linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Edad:" + edad);
        }

        public void EsMayorEdad()
        {
            if (edad >= 18)
            {
                Console.Write(nombre + " es mayor de edad.");
            }
            else
            {
                Console.Write(nombre + " no es mayor de edad.");
            }
        }           
    }
}
