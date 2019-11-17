using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
        public Cliente Cliente { get; set; }
    }
}
