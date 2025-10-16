using System.Threading;

namespace Eliminar_Tareas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas registradas.");
                return;
            }

            ListarTareas();
            Console.Write("\nIngrese el número de la tarea: ");
            int num = int.Parse(Console.ReadLine());

            }
        }
    }
}
