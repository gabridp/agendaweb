using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgendaWeb.Presentation.Controllers
{
    [Authorize]
    public class UsuarioController : Controller
    {
        //método para abrir a página 'MinhaConta'
        public IActionResult MinhaConta()
        {
            return View();
        }
    }
}


