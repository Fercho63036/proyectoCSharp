using MiProyectoCSharp.POO;

namespace MiProyectoCSharp.RepositoriosServicios;

public class ProductoRepository
{
    private List<Producto> productos = new List<Producto>();
    
    public void Agregar(Producto producto)
    {
        productos.Add(producto);
        Console.WriteLine($"Producto '{producto.Nombre}' agregado al repositorio");
    }
    
    public List<Producto> ObtenerTodos()
    {
        return productos;
    }
    
    public Producto? ObtenerPorNombre(string nombre)
    {
        return productos.FirstOrDefault(p => p.Nombre == nombre);
    }
}