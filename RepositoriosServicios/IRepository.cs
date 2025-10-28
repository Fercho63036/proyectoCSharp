namespace MiProyectoCSharp.RepositoriosServicios;

public interface IRepository<T>
{
    void Agregar(T item);
    T? ObtenerPorId(int id);
    List<T> ObtenerTodos();
    void Eliminar(int id);
}