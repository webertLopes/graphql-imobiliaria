using Imobiliaria.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria.DataAccess.Repositories.Contracts
{
    public interface IImoveisRepository
    {
        IEnumerable<Imovel> GetAll();
        Imovel GetById(int id);
        Imovel Add(Imovel imovel);
    }
}
