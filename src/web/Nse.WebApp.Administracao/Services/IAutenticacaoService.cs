using Nse.WebApp.Administracao.Models;
using System.Threading.Tasks;

namespace Nse.WebApp.Administracao.Services
{
    public interface IAutenticacaoService
    {
        Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin);
        Task<string> Registro(UsuarioRegistro usuarioRegistro);
    }
}
