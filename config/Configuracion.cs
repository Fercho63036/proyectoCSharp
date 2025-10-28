namespace MiProyectoCSharp.Config;

public class Configuracion
{
    // Variables de configuración (simulando variables de entorno)
    public static string EntornoEjecucion { get; set; } = "Desarrollo";
    public static string CadenaConexion { get; set; } = "Server=localhost;Database=MiDB;";
    public static int PuertoApi { get; set; } = 5000;
    
    public static void MostrarConfiguracion()
    {
        Console.WriteLine("\n--- Configuración ---");
        Console.WriteLine($"Entorno: {EntornoEjecucion}");
        Console.WriteLine($"Cadena de conexión: {CadenaConexion}");
        Console.WriteLine($"Puerto API: {PuertoApi}");
    }
    
    // Para leer variables de entorno reales:
    public static string ObtenerVariableEntorno(string nombreVariable)
    {
        return Environment.GetEnvironmentVariable(nombreVariable) ?? "No encontrada";
    }
}