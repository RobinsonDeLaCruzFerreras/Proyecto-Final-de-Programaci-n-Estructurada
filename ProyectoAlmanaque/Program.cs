using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlmanaque
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PROGRAMA QUE CALCULA EL PROMEDIO DE TRES NOTAS DE UN ALUMNO*/

            Console.WriteLine("PROGRAMACION ESTRUCTURADA O&M / Seccion: 0463");
            Console.WriteLine("INGENIERIA INDUSTRIAL - Grade Calculator");

            Console.WriteLine("Grade Calculator - By:");
            Console.WriteLine("Robinson De La Cruz  18-SIIN-1-063");
            Console.WriteLine("Julián Candelario    14-SIIN-1-035");
           

            //INTRODUCCION O DECLARACION DE LAS VARIABLES
            int nota1, nota2, nota3;
            string linea;
            Console.Write("Ingrese la primera nota");
            linea = Console.ReadLine();
            nota1 = int.Parse(linea);
            Console.Write("Ingrese la segunda nota");
            linea = Console.ReadLine();
            nota2 = int.Parse(linea);
            Console.Write("Ingrese la tercera nota");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);
            int promedio = (nota1 + nota2 + nota3) / 3;

            //CONDICIONES IF
            if (promedio > 70)
            {
                Console.Write("Aprobado");
            }
            else
            {
                if (promedio < 65)
                {
                    Console.Write("Reprobado");
                }
                else

                //IMPLEMENTACION DEL BUCLE
                {
                    for (promedio = 5; promedio <= 70; promedio++);
                    Console.Write("Aprobado por ayuda:");
                    Console.WriteLine(promedio);
                }
            }
            Console.ReadKey();

            /* Programa realizado por:
             * Robinson De La Cruz  18-SIIN-1-063 SECCION 0463
             * Julián Candelario    14-SIIN-1-035 SECCION 0463*/
           
        }
    }
}
