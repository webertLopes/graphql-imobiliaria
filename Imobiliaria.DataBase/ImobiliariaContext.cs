using Imobiliaria.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imobiliaria.DataBase
{
    public class ImobiliariaContext : DbContext
    {
        public ImobiliariaContext(DbContextOptions<ImobiliariaContext> options)
            :base(options)
        {

        }
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
    }
}
