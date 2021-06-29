using GraphQL.Types;

namespace Imobiliaria.Types.Pagamento
{
    public class PagamentoInputType : InputObjectGraphType
    {
        public PagamentoInputType()
        {
            Field<NonNullGraphType<IntGraphType>>("valor");
            Field<NonNullGraphType<DateGraphType>>("dataCriacao");
            Field<NonNullGraphType<DateGraphType>>("dataVencimento");
            Field<NonNullGraphType<BooleanGraphType>>("paga");
            Field<NonNullGraphType<IntGraphType>>("imovelId");
        }
    }
}
