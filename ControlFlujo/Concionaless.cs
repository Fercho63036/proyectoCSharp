namespace MiProyectoCSharp.ControlFlujo;

public class Condicionales
{
    public static void Ejecutar()
    {
        Console.WriteLine("\n--- Condicionales ---");
        
        // IF-ELSE
        int edad = 18;
        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            Console.WriteLine("Eres menor de edad");
        }
        
        // SWITCH
        string dia = "Lunes";
        switch (dia)
        {
            case "Lunes":
                Console.WriteLine("Inicio de semana");
                break;
            case "Viernes":
                Console.WriteLine("Fin de semana laboral");
                break;
            default:
                Console.WriteLine("Día de semana normal");
                break;
        }
        
        // Operador ternario
        int nota = 85;
        string resultado = nota >= 60 ? "Aprobado" : "Reprobado";
        Console.WriteLine($"Resultado: {resultado}");
    }
}