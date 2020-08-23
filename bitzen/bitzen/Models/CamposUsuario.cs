using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitzen.Models
{
    public class CamposUsuario : IdentityUser
    {
        public string  NomeCompleto { get; set; }

    }
}
