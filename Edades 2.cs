using System;
using System.Collections.Generic;

namespace ProgramacionEstructurada
{
    internal class Progra
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa para clasificar personas");

            int cantidad = LeerEnteroPositivo("Ingresa la cantidad de personas a registrar: ");

            List<string> nombresMayores = new List<string>();
            List<int> edadesMayores = new List<int>();
            List<string> nombresMenores = new List<string>();
            List<int> edadesMenores = new List<int>();

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($" Registro de la persona {i + 1}:");
                Console.Write("Ingresa el nombre: ");
                string nombre = Console.ReadLine();

                int edad = LeerEnteroPositivo("Ingresa la edad: ");

                if (EsMayorDeEdad(edad))
                {
                    nombresMayores.Add(nombre);
                    edadesMayores.Add(edad);
                }
                else
                {
                    nombresMenores.Add(nombre);
                    edadesMenores.Add(edad);
                }
            }

            Console.WriteLine("--- RESULTADOS ---");
            MostrarLista("Personas Mayores", nombresMayores, edadesMayores);
            MostrarLista("Personas Menores", nombresMenores, edadesMenores);

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }


        static int LeerEnteroPositivo(string mensaje)
        {
            int valor;
            while (true)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out valor) && valor >= 0)
                    return valor;
                Console.WriteLine("Error: Ingrese un número válido y positivo.");
            }
        }

        static bool EsMayorDeEdad(int edad)
        {
            return edad >= 18;
        }

        static void MostrarLista(string titulo, List<string> nombres, List<int> edades)
        {
            if (nombres.Count > 0)
            {
                Console.WriteLine($"{titulo}:");
                for (int i = 0; i < nombres.Count; i++)
                {
                    Console.WriteLine($"- {nombres[i]}: {edades[i]} años");
                }
            }
        }
    }
}