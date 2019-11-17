﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public String nome { get; set; }
        public List<Filme> Filmes { get; set; }
    }
}