using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confeitaria.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Complemento { get; set; }
        public int? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int? EstabelecimentoId { get; set; }
        public Estabelecimento Estabelecimento { get; set; }


    }
}
