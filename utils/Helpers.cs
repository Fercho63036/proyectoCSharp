namespace MiProyectoCSharp.Utils;

public class Helpers
{
    public static string FormatearFecha(DateTime fecha)
    {
        return fecha.ToString("dd/MM/yyyy");
    }
    
    public static string CapitalizarPrimeraLetra(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return texto;
        
        return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
    }
    
    public static double CalcularPorcentaje(double valor, double total)
    {
        if (total == 0) return 0;
        return (valor / total) * 100;
    }
    
    public static void ImprimirSeparador(string titulo = "")
    {
        Console.WriteLine($"\n========== {titulo} ==========");
    }
}