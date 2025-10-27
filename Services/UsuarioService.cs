// Services/UsuarioService.cs
using MiProyectoCSharp.Models;
using System;

namespace MiProyectoCSharp.Services
{
    public class UsuarioService
    {
        public void MostrarUsuario(Usuario usuario)
        {
            Console.WriteLine($"Nombre: {usuario.Nombre}, Edad: {usuario.Edad}");
        }
    }
}
