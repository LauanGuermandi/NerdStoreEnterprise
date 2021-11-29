using Nse.WebApp.Administracao.Extensions;
using System.Net.Http;

namespace Nse.WebApp.Administracao.Services
{
    public abstract class Service
    {
        protected bool TratarErrosResponse(HttpResponseMessage reponse)
        {
            switch ((int)reponse.StatusCode)
            {
                case 401:
                case 403:
                case 404:
                case 500:
                    throw new CustomHttpRequestException(reponse.StatusCode);

                case 400:
                    return false;
            }

            reponse.EnsureSuccessStatusCode();
            return true;
        }
    }
}
