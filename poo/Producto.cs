namespace MiProyectoCSharp.POO;

public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    
    public Producto(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
    
    public void AplicarDescuento(decimal porcentaje)
    {
        decimal descuento = Precio * (porcentaje / 100);
        Precio -= descuento;
        Console.WriteLine($"Descuento del {porcentaje}% aplicado. Nuevo precio: ${Precio:F2}");
    }
    
    public void MostrarInfo()
    {
        Console.WriteLine($"Producto: {Nombre}, Precio: ${Precio:F2}");
    }
}