using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitzen.Models
{
    public class RelatorioMediaMensalPorCarro
    {
        public string Placa { get; set; }

        public  List <MediaLitros> media { get; set; }

    }
}
