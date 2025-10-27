using MiProyectoCSharp.Models;
using MiProyectoCSharp.Services;
using MiProyectoCSharp.Utils;

class Program
{
    static void Main(string[] args)
    {
        Usuario usuario = new Usuario { Nombre = "Ariel", Edad = 26 };
        UsuarioService service = new UsuarioService();

        Helper.Saludo(usuario.Nombre);
        service.MostrarUsuario(usuario);
    }
}
