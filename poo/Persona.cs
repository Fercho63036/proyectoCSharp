namespace MiProyectoCSharp.POO;

public class Persona
{
    // Propiedades
    public string Nombre { get; set; }
    public int Edad { get; set; }
    
    // Constructor
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
    
    // Métodos
    public void MostrarInfo()
    {
        Console.WriteLine($"\nPersona: {Nombre}, Edad: {Edad} años");
    }
    
    public bool EsMayorDeEdad()
    {
        return Edad >= 18;
    }
}