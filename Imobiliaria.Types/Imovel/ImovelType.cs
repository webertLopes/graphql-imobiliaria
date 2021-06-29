using GraphQL.Types;
using Imobiliaria.DataAccess.Repositories.Contracts;
using Imobiliaria.Types.Pagamento;

namespace Imobiliaria.Types
{
    public class ImovelType : ObjectGraphType<DataBase.Models.Imovel>
    {
        public ImovelType(IPagamentoRepository pagamentoRepository)
        {
            Field(x => x.Id);
            Field(x => x.Familia);
            Field(x => x.Cidade);
            Field(x => x.Logradouro);
            Field(x => x.Nome);
            Field(x => x.Preco);
            Field<ListGraphType<PagamentoType>>("pagamentos",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "ultimosPagamento" }),
                resolve: context => {
                    var ultimoItem = context.GetArgument<int?>("ultimosPagamento");
                    return ultimoItem != null
                           ? pagamentoRepository.GetAllForPagamento(context.Source.Id, ultimoItem.Value)
                           : pagamentoRepository.GetAllForPagamento(context.Source.Id);
                });
        }
    }
}
