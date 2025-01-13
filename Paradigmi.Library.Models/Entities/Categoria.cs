using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigmi.Library.Models.Entities
{
    public class Categoria
    {
        public string Nome { get; set; } = string.Empty;
        public ICollection<Libro> Libro { get; set; } = new List<Libro>();
    }
}
