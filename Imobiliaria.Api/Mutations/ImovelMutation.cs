using GraphQL.Types;
using Imobiliaria.DataAccess.Repositories.Contracts;
using Imobiliaria.DataBase.Models;
using Imobiliaria.Types;
using Imobiliaria.Types.Imovel;
using Imobiliaria.Types.Pagamento;

namespace Imobiliaria.Api.Mutations
{
    public class ImovelMutation : ObjectGraphType
    {
        public ImovelMutation(IImoveisRepository imovelRepository, IPagamentoRepository pagamentoRepository)
        {
            Field<ImovelType>(
                "adicionarImovel",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ImovelInputType>> { Name = "imovel" }),
                resolve: context =>
                {
                    var imovel = context.GetArgument<Imovel>("imovel");
                    return imovelRepository.Add(imovel);
                });

            Field<PagamentoType>(
                "addPagamento",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PagamentoInputType>> { Name = "pagamento" }),
                resolve: context =>
                {
                    var pagamento = context.GetArgument<Pagamento>("pagamento");
                    return pagamentoRepository.Add(pagamento);
                });
        }
    }
}
