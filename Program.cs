// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace GestorDeTareas
{
    class Program
    {
        static List<string> tareas = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("=== Gestor de Tareas ===");
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n1. Agregar tarea");
                Console.WriteLine("2. Ver tareas");
                Console.WriteLine("3. Salir");
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarTarea();
                        break;
                    case "2":
                        MostrarTareas();
                        break;
                    case "3":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }

            Console.WriteLine("¡Hasta luego!");
        }

        static void AgregarTarea()
        {
            Console.Write("Escribe la descripción de la tarea: ");
            string descripcion = Console.ReadLine();
            tareas.Add(descripcion);
            Console.WriteLine("Tarea agregada correctamente.");
        }

        static void MostrarTareas()
        {
            Console.WriteLine("\n=== Lista de Tareas ===");
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas registradas.");
            }
            else
            {
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tareas[i]}");
                }
            }
        }
    }
}
