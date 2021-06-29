using GraphQL.Types;
using Imobiliaria.DataAccess.Repositories.Contracts;
using Imobiliaria.Types;
using Imobiliaria.Types.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Api.Queries
{
    public class ImovelQuery : ObjectGraphType
    {
        public ImovelQuery(IImoveisRepository imovelRepository, IPagamentoRepository pagamentoRepository)
        {
            Field<ListGraphType<ImovelType>>(
                "imoveis",
                resolve: context => imovelRepository.GetAll());

            Field<ImovelType>(
                "imovel",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => imovelRepository.GetById(context.GetArgument<int>("id")));

            Field<ListGraphType<PagamentoType>>(
               "pagamentos",
               resolve: context => pagamentoRepository.GetAll());

            Field<ListGraphType<PagamentoType>>("pagamento",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "ultimosPagamento" },
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "imovelId" }
                    ),
                resolve: context => {
                    var ultimoItem = context.GetArgument<int?>("ultimosPagamento");
                    var imovelId = context.GetArgument<int>("imovelId");

                    return ultimoItem != null
                           ? pagamentoRepository.GetAllForPagamento(imovelId, ultimoItem.Value)
                           : pagamentoRepository.GetAllForPagamento(imovelId);
                });

        }
    }
}
