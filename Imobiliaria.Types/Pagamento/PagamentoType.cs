using GraphQL.Types;
using Imobiliaria.DataAccess.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria.Types.Pagamento
{
    public class PagamentoType : ObjectGraphType<DataBase.Models.Pagamento>
    {
        public PagamentoType(IPagamentoRepository pagamentoRepository)
        {
            Field(x => x.Id);
            Field(x => x.Valor);
            Field(x => x.DataCriacao);
            Field(x => x.DataVencimento);
            Field(x => x.Paga);            
        }
    }
}
