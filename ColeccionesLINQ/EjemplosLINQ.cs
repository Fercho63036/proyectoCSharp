namespace MiProyectoCSharp.ColeccionesLINQ;

public class EjemplosLINQ
{
    public static void Ejecutar()
    {
        Console.WriteLine("\n--- LINQ ---");
        
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Where - Filtrar
        var pares = numeros.Where(n => n % 2 == 0);
        Console.WriteLine("Números pares: " + string.Join(", ", pares));
        
        // Select - Transformar
        var cuadrados = numeros.Select(n => n * n);
        Console.WriteLine("Cuadrados: " + string.Join(", ", cuadrados));
        
        // OrderBy - Ordenar
        var descendente = numeros.OrderByDescending(n => n);
        Console.WriteLine("Descendente: " + string.Join(", ", descendente));
        
        // First - Primer elemento
        var primero = numeros.First();
        Console.WriteLine($"Primer número: {primero}");
        
        // Sum, Average, Max, Min
        Console.WriteLine($"Suma: {numeros.Sum()}");
        Console.WriteLine($"Promedio: {numeros.Average()}");
        Console.WriteLine($"Máximo: {numeros.Max()}");
        Console.WriteLine($"Mínimo: {numeros.Min()}");
    }
}