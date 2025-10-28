namespace MiProyectoCSharp.ColeccionesLINQ;

public class EjemplosListas
{
    public static void Ejecutar()
    {
        Console.WriteLine("\n--- Listas ---");
        
        // Crear lista
        List<string> ciudades = new List<string> { "Cochabamba", "La Paz", "Santa Cruz" };
        
        // Agregar elementos
        ciudades.Add("Sucre");
        ciudades.Add("Oruro");
        
        // Mostrar elementos
        Console.WriteLine("Ciudades:");
        foreach (var ciudad in ciudades)
        {
            Console.WriteLine($"- {ciudad}");
        }
        
        // Operaciones
        Console.WriteLine($"Total de ciudades: {ciudades.Count}");
        Console.WriteLine($"¿Contiene 'La Paz'?: {ciudades.Contains("La Paz")}");
        
        // Remover elemento
        ciudades.Remove("Oruro");
        Console.WriteLine($"Después de remover Oruro: {ciudades.Count} ciudades");
    }
}