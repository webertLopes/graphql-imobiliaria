using GraphQL;
using Imobiliaria.Api.Mutations;
using Imobiliaria.Api.Queries;

namespace Imobiliaria.Api.Schema
{
    public class ImobiliariaSchema : GraphQL.Types.Schema
    {
        public ImobiliariaSchema(IDependencyResolver resolver)
            :base(resolver)
        {
            Query = resolver.Resolve<ImovelQuery>();
            Mutation = resolver.Resolve<ImovelMutation>();
        }
    }
}
