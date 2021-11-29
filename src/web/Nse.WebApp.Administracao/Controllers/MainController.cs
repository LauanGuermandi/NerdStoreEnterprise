using Microsoft.AspNetCore.Mvc;
using Nse.WebApp.Administracao.Models;
using System.Linq;

namespace Nse.WebApp.Administracao.Controllers
{
    public abstract class MainController : Controller
    {
        protected bool ResponsePossuiErros(ResponseResult resposta)
        {
            if (resposta != null && resposta.Errors.Mensagens.Any())
            {
                return true;
            }

            return false;
        }
    }
}
