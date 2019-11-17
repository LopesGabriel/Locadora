using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Filme> Filmes { get; set; } = new List<Filme>();
        public DateTime DataLocacao { get; set; }
        public DateTime DataEntrega { get; set; }
    }
}
