using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confeitaria.Models
{
    public class Bolo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Ingredientes { get; set; }
        public double preco { get; set; }

    }
}
