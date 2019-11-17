using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Models
{
    public class Produtora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Filme> Filmes { get; set; } = new List<Filme>();
    }
}
