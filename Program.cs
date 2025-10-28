using MiProyectoCSharp.Fundamentos;
using MiProyectoCSharp.ControlFlujo;
using MiProyectoCSharp.POO;
using MiProyectoCSharp.RepositoriosServicios;
using MiProyectoCSharp.ColeccionesLINQ;
using MiProyectoCSharp.Config;
using MiProyectoCSharp.Utils;

namespace MiProyectoCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== MI PROYECTO C# ===\n");

        // Descomentar el ejercicio que quieras probar:

        // === FUNDAMENTOS ===
        EjecutarFundamentos();

        // === CONTROL DE FLUJO ===
        // EjecutarControlFlujo();

        // === POO ===
        // EjecutarPOO();

        // === REPOSITORIOS Y SERVICIOS ===
        // EjecutarRepositoriosServicios();

        // === COLECCIONES Y LINQ ===
        // EjecutarColeccionesLINQ();

        // === CONFIGURACIÓN ===
        // EjecutarConfiguracion();

        Console.WriteLine("\n=== FIN DEL PROGRAMA ===");
    }

    static void EjecutarFundamentos()
    {
        Console.WriteLine("--- FUNDAMENTOS ---");
        Variables.Ejecutar();
        TiposDatos.Ejecutar();
    }

    static void EjecutarControlFlujo()
    {
        Console.WriteLine("--- CONTROL DE FLUJO ---");
        Condicionales.Ejecutar();
        Bucles.Ejecutar();
    }

    static void EjecutarPOO()
    {
        Console.WriteLine("--- POO ---");
        
        var persona = new Persona("Juan", 25);
        persona.MostrarInfo();

        var producto = new Producto("Laptop", 1200.50m);
        producto.AplicarDescuento(10);
        producto.MostrarInfo();

        var cuenta = new Cuenta("Carlos", 1000);
        cuenta.Depositar(500);
        cuenta.Retirar(200);
        cuenta.MostrarSaldo();
    }

    static void EjecutarRepositoriosServicios()
    {
        Console.WriteLine("--- REPOSITORIOS Y SERVICIOS ---");
        
        var productoService = new ProductoService();
        
        productoService.AgregarProducto(new Producto("Mouse", 25.99m));
        productoService.AgregarProducto(new Producto("Teclado", 75.50m));
        
        productoService.MostrarTodosLosProductos();
        
        var producto = productoService.ObtenerProductoPorNombre("Mouse");
        producto?.MostrarInfo();
    }

    static void EjecutarColeccionesLINQ()
    {
        Console.WriteLine("--- COLECCIONES Y LINQ ---");
        EjemplosListas.Ejecutar();
        EjemplosDiccionarios.Ejecutar();
        EjemplosLINQ.Ejecutar();
    }

    static void EjecutarConfiguracion()
    {
        Console.WriteLine("--- CONFIGURACIÓN ---");
        Configuracion.MostrarConfiguracion();
    }
}