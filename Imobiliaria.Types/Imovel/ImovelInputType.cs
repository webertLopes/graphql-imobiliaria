using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria.Types.Imovel
{
    public class ImovelInputType : InputObjectGraphType
    {
        public ImovelInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("nome");
            Field<StringGraphType>("cidade");
            Field<StringGraphType>("logradouro");
            Field<IntGraphType>("preco");
            Field<StringGraphType>("familia");

        }
    }
}
