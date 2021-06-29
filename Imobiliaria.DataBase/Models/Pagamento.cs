using System;

namespace Imobiliaria.DataBase.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Paga { get; set; }
        public int ImovelId { get; set; }
        public Imovel Imovel { get; set; }
    }
}
