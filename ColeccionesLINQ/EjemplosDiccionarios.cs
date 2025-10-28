namespace MiProyectoCSharp.ColeccionesLINQ;

public class EjemplosDiccionarios
{
    public static void Ejecutar()
    {
        Console.WriteLine("\n--- Diccionarios ---");
        
        // Crear diccionario
        Dictionary<string, int> edades = new Dictionary<string, int>
        {
            { "Juan", 25 },
            { "María", 30 },
            { "Pedro", 28 }
        };
        
        // Agregar elemento
        edades["Ana"] = 22;
        
        // Acceder a elementos
        Console.WriteLine($"Edad de Juan: {edades["Juan"]}");
        
        // Iterar
        Console.WriteLine("\nTodas las edades:");
        foreach (var kvp in edades)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} años");
        }
        
        // Verificar existencia
        if (edades.ContainsKey("María"))
        {
            Console.WriteLine("María está en el diccionario");
        }
    }
}