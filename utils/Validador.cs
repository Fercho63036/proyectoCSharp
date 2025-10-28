namespace MiProyectoCSharp.Utils;

public class Validador
{
    public static bool EsEmailValido(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }
    
    public static bool EsNumeroPositivo(int numero)
    {
        return numero > 0;
    }
    
    public static bool EsTextoVacio(string texto)
    {
        return string.IsNullOrWhiteSpace(texto);
    }
    
    public static bool EstaEnRango(int valor, int min, int max)
    {
        return valor >= min && valor <= max;
    }
}