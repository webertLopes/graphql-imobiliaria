using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria.DataBase.Models
{
    public class Imovel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public decimal Preco { get; set; }
        public string Familia { get; set; }
        public ICollection<Pagamento> Pagamentos { get; set; }
    }
}
