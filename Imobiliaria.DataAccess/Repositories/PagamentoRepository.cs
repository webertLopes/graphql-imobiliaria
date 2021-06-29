using Imobiliaria.DataAccess.Repositories.Contracts;
using Imobiliaria.DataBase;
using Imobiliaria.DataBase.Models;
using System.Collections.Generic;
using System.Linq;

namespace Imobiliaria.DataAccess.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private readonly ImobiliariaContext _dbContext;
        public PagamentoRepository(ImobiliariaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Pagamento Add(Pagamento pagamento)
        {
            _dbContext.Pagamentos.Add(pagamento);
            _dbContext.SaveChanges();
            return pagamento;
        }

        public IEnumerable<Pagamento> GetAll()
        {
            return _dbContext.Pagamentos;
        }

        public IEnumerable<Pagamento> GetAllForPagamento(int imovelId)
        {
            return _dbContext.Pagamentos.Where(x => x.ImovelId == imovelId);
        }

        public IEnumerable<Pagamento> GetAllForPagamento(int imovelId, int ultimoPagamento)
        {
            return _dbContext.Pagamentos.Where(x => x.ImovelId == imovelId)
                .OrderByDescending(x => x.DataCriacao)
                .Take(ultimoPagamento);
        }
    }
}
