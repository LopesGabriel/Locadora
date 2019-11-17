using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public int Ano { get; set; }
        public Categoria Categoria { get; set; }
        public Produtora Produtora { get; set; }
    }
}
