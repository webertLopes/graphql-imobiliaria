using Imobiliaria.DataAccess.Repositories.Contracts;
using Imobiliaria.DataBase;
using Imobiliaria.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Imobiliaria.DataAccess.Repositories
{
    public class ImoveisRepository : IImoveisRepository
    {
        private readonly ImobiliariaContext _dbContext;
        public ImoveisRepository(ImobiliariaContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public Imovel Add(Imovel imovel)
        {
            _dbContext.Imoveis.Add(imovel);
            _dbContext.SaveChanges();
            return imovel;
        }

        public IEnumerable<Imovel> GetAll()
        {
            return _dbContext.Imoveis;
        }

        public Imovel GetById(int id)
        {
            return _dbContext.Imoveis.SingleOrDefault(x => x.Id == id);
        }
    }
}
