using System.Collections.Generic;

namespace ProgramacionEstructurada
{
    internal class Programacion
    {
        static void Main(string[] args)
        {
            int cantidadPersonas;
            string nombrePersona;
            int edadPersona;

            Console.WriteLine("Bienvenido al programa para poder clasificar personas");

            while (true)
            {
                Console.Write("Ingresa la cantidad de personas a registrar: ");
                if (int.TryParse(Console.ReadLine(), out cantidadPersonas) && cantidadPersonas >= 1) break;
                Console.WriteLine("El valor es inválido, ingrese un número mayor o igual a 1.");
            }

            if (cantidadPersonas == 1)
            {
                Console.WriteLine("Ingrese el nombre de la persona 1");
                nombrePersona = Console.ReadLine();

                Console.WriteLine("Ingrese la edad de la persona 1");
                while (!int.TryParse(Console.ReadLine(), out edadPersona))
                {
                    Console.WriteLine("Edad inválida, intente de nuevo:");
                }

                if (edadPersona < 18)
                {
                    Console.WriteLine(nombrePersona + " Es menor de edad");
                }
                else
                {
                    Console.WriteLine(nombrePersona + " Es mayor de edad");
                }
            }
            else
            {
                List<int> edadesPersonasMenores = new List<int>();
                List<int> edadesPersonasMayores = new List<int>();
                List<string> nombresPersonasMenores = new List<string>();
                List<string> nombresPersonasMayores = new List<string>();

                for (int i = 0; i < cantidadPersonas; i++)
                {
                    Console.WriteLine($"Registro de la persona {i + 1}:");
                    Console.WriteLine("Ingresa el nombre de la persona");
                    nombrePersona = Console.ReadLine();

                    Console.WriteLine("Ingresa la edad de la persona");
                    while (!int.TryParse(Console.ReadLine(), out edadPersona))
                    {
                        Console.WriteLine("Edad inválida. Intente de nuevo:");
                    }

                    if (edadPersona < 18)
                    {
                        nombresPersonasMenores.Add(nombrePersona);
                        edadesPersonasMenores.Add(edadPersona);
                    }
                    else
                    {
                        nombresPersonasMayores.Add(nombrePersona);
                        edadesPersonasMayores.Add(edadPersona);
                    }
                }


                if (nombresPersonasMayores.Count > 0)
                {
                    Console.WriteLine("Edades personas mayores:");
                    for (int i = 0; i < nombresPersonasMayores.Count; i++)
                    {
                        Console.WriteLine($"{nombresPersonasMayores[i]} - {edadesPersonasMayores[i]} años");
                    }
                }

                if (nombresPersonasMenores.Count > 0)
                {
                    Console.WriteLine("Edades personas menores:");
                    for (int i = 0; i < nombresPersonasMenores.Count; i++)
                    {
                        Console.WriteLine($"{nombresPersonasMenores[i]} - {edadesPersonasMenores[i]} años");
                    }
                }
            }

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}