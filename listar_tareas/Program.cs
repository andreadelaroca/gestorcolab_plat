using System;
using System.Collections.Generic;

class Tarea
{
    public string Descripcion { get; set; }
    public bool Completa { get; set; }

    public Tarea(string descripcion, bool completa = false)
    {
        Descripcion = descripcion;
        Completa = completa;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Prueba 1: Lista con tareas incompletas");
        var tareas1 = new List<Tarea>
        {
            new Tarea("Preparar presentación"),
            new Tarea("Revisar ejercicios", true),
            new Tarea("Enviar retroalimentación")
        };
        ListarTareasPendientes(tareas1);

        Console.WriteLine("Prueba 2: Todas las tareas completas");
        var tareas2 = new List<Tarea>
        {
            new Tarea("Tarea A", true),
            new Tarea("Tarea B", true)
        };
        ListarTareasPendientes(tareas2);

        Console.WriteLine("Prueba 3: Lista vacía");
        var tareas3 = new List<Tarea>();
        ListarTareasPendientes(tareas3);
    }

    static void ListarTareasPendientes(List<Tarea> tareas)
    {
        bool hayPendientes = false;
        Console.WriteLine("Tareas pendientes:");

        for (int i = 0; i < tareas.Count; i++)
        {
            if (!tareas[i].Completa)
            {
                Console.WriteLine($"{i + 1}. {tareas[i].Descripcion}");
                hayPendientes = true;
            }
        }

        if (!hayPendientes)
            Console.WriteLine("No hay tareas pendientes.");
    }
}

