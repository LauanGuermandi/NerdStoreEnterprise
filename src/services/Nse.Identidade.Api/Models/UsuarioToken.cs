using System;
using System.Collections.Generic;

namespace Nse.Identidade.Api.Models
{
    public class UsuarioToken
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<UsuarioClaim> Claims { get; set; }
    }
}