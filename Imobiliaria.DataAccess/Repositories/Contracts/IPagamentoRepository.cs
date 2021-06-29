using Imobiliaria.DataBase.Models;
using System.Collections.Generic;

namespace Imobiliaria.DataAccess.Repositories.Contracts
{
    public interface IPagamentoRepository
    {
        IEnumerable<Pagamento> GetAll();
        IEnumerable<Pagamento> GetAllForPagamento(int imovelId);
        IEnumerable<Pagamento> GetAllForPagamento(int imovelId, int ultimoPagamento);
        Pagamento Add(Pagamento pagamento);
    }
}
