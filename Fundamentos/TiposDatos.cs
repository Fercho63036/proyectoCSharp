namespace MiProyectoCSharp.Fundamentos;
public class TiposDatos
{
    public static void Ejecutar()
    {
        Console.WriteLine("\n--- Tipos de Datos ---");
        // Tipos numéricos
        byte edad = 25;              // 0 a 255
        int habitantes = 1000000;    // -2,147,483,648 a 2,147,483,647
        long poblacion = 8000000000; // Números muy grandes
        float precio = 19.99f;       // Decimal de precisión simple
        double distancia = 384400.5; // Decimal de doble precisión
        decimal dinero = 1234.56m;   // Alta precisión para dinero
        // Tipos de texto
        char inicial = 'M';
        string mensaje = "Hola C#";
        // Tipos lógicos
        bool activo = true;
        Console.WriteLine($"byte: {edad}");
        Console.WriteLine($"int: {habitantes}");
        Console.WriteLine($"long: {poblacion}");
        Console.WriteLine($"float: {precio}");
        Console.WriteLine($"double: {distancia}");
        Console.WriteLine($"decimal: {dinero}");
        Console.WriteLine($"char: {inicial}");
        Console.WriteLine($"string: {mensaje}");
        Console.WriteLine($"bool: {activo}");
    }
}