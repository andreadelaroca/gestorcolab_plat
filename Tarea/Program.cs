static void CompletarTarea(List<Tarea> tareas)
{
    if (tareas.Count == 0)
    {
        Console.WriteLine("No hay tareas para completar.");
        return;
    }

    for (int i = 0; i < tareas.Count; i++)
        Console.WriteLine($"{i + 1}. {tareas[i].Descripcion} - {(tareas[i].Completa ? "Completa" : "Incompleta")}");

    Console.Write("Número de tarea a completar: ");
    if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= tareas.Count)
    {
        tareas[num - 1].Completa = true;
        Console.WriteLine($"La tarea '{tareas[num - 1].Descripcion}' ahora está completa.");
    }
    else
    {
        Console.WriteLine("Número inválido.");
    }
}
