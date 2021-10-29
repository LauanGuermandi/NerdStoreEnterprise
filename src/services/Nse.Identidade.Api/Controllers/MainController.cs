using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace Nse.Identidade.Api.Controllers
{
    [ApiController]
    public abstract class MainController : Controller
    {
        protected ICollection<string> Errors = new List<string>();

        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaValida())
            {
                return Ok(result);
            }

            return BadRequest(new ValidationProblemDetails(new Dictionary<string, string[]>
            {
                { "Mensagens", Errors.ToArray() }
            }));
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var erro in erros)
            {
                AdicionarErrosProcessamento(erro.ErrorMessage);
            }

            return CustomResponse();
        }

        protected bool OperacaValida()
        {
            return !Errors.Any();
        }

        protected void AdicionarErrosProcessamento(string erro)
        {
            Errors.Add(erro);
        }

        protected void LimparErros()
        {
            Errors.Clear();
        }
    }
}
