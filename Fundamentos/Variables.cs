namespace MiProyectoCSharp.Fundamentos;

public class Variables
{
    public static void Ejecutar()
    {
        Console.WriteLine("\n--- Variables ---");
        
        // Variables locales
        int edad = 30;
        string nombre = "María";
        double altura = 1.65;
        bool esEstudiante = true;
        
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Altura: {altura}m");
        Console.WriteLine($"¿Es estudiante?: {esEstudiante}");
        
        // Variables con var (inferencia de tipo)
        var ciudad = "Cochabamba";
        var temperatura = 22.5;
        
        Console.WriteLine($"Ciudad: {ciudad}, Temperatura: {temperatura}°C");
    }
}