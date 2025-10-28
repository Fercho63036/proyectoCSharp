using MiProyectoCSharp.POO;

namespace MiProyectoCSharp.RepositoriosServicios;

public class ProductoService
{
    private ProductoRepository _repository;
    
    public ProductoService()
    {
        _repository = new ProductoRepository();
    }
    
    public void AgregarProducto(Producto producto)
    {
        _repository.Agregar(producto);
    }
    
    public void MostrarTodosLosProductos()
    {
        var productos = _repository.ObtenerTodos();
        Console.WriteLine("\n--- Lista de Productos ---");
        foreach (var producto in productos)
        {
            producto.MostrarInfo();
        }
    }
    
    public Producto? ObtenerProductoPorNombre(string nombre)
    {
        return _repository.ObtenerPorNombre(nombre);
    }
}