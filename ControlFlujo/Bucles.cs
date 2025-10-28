namespace MiProyectoCSharp.ControlFlujo;

public class Bucles
{
    public static void Ejecutar()
    {
        Console.WriteLine("\n--- Bucles ---");
        
        // FOR
        Console.WriteLine("Bucle FOR:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Iteración {i}");
        }
        
        // WHILE
        Console.WriteLine("\nBucle WHILE:");
        int contador = 0;
        while (contador < 3)
        {
            Console.WriteLine($"Contador: {contador}");
            contador++;
        }
        
        // DO-WHILE
        Console.WriteLine("\nBucle DO-WHILE:");
        int num = 0;
        do
        {
            Console.WriteLine($"Número: {num}");
            num++;
        } while (num < 3);
        
        // FOREACH
        Console.WriteLine("\nBucle FOREACH:");
        string[] frutas = { "Manzana", "Banana", "Naranja" };
        foreach (var fruta in frutas)
        {
            Console.WriteLine($"Fruta: {fruta}");
        }
    }
}