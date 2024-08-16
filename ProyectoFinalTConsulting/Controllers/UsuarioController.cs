using Microsoft.AspNetCore.Mvc;
using ProyectoFinalTConsulting.servicios;

public class UsuarioController : Controller
{
    private readonly UsuarioRepositorio _usuarioRepositorio;

    public UsuarioController(UsuarioRepositorio usuarioRepositorio)
    {
        _usuarioRepositorio = usuarioRepositorio;
    }

    public async Task<IActionResult> Index()
    {
        var usuarios = await _usuarioRepositorio.ObtenerTodosUsuariosAsync();
        return View(usuarios);
    }
}
