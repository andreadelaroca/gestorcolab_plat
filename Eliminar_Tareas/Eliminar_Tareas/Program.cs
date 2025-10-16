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

            if (num < 1 || num > tareas.Count)
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            Console.Write("¿Desea (1) completar o (2) eliminar la tarea?: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                tareas[num - 1].Completada = true;
                Console.WriteLine("Tarea marcada como completada.");
            }
            else if (opcion == 2)
            {
                tareas.RemoveAt(num - 1);
                Console.WriteLine("Tarea eliminada.");
            }

        }
        
    }
}
