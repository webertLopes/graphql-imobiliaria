using GraphiQl;
using GraphQL;
using GraphQL.Types;
using Imobiliaria.Api.Mutations;
using Imobiliaria.Api.Queries;
using Imobiliaria.Api.Schema;
using Imobiliaria.DataAccess.Repositories;
using Imobiliaria.DataAccess.Repositories.Contracts;
using Imobiliaria.DataBase;
using Imobiliaria.Types;
using Imobiliaria.Types.Imovel;
using Imobiliaria.Types.Pagamento;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Imobiliaria.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<IImoveisRepository, ImoveisRepository>();
            services.AddTransient<IPagamentoRepository, PagamentoRepository>();
            services.AddDbContext<ImobiliariaContext>(option => option.UseSqlServer(Configuration["ConnectionStrings:ApresentacaoDb"]));
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<PagamentoInputType>();
            services.AddSingleton<ImovelQuery>();
            services.AddSingleton<ImovelMutation>();
            services.AddSingleton<ImovelInputType>();
            services.AddSingleton<ImovelType>();
            services.AddSingleton<PagamentoType>();
            var sp = services.BuildServiceProvider();
            services.AddSingleton<ISchema>(new ImobiliariaSchema(new FuncDependencyResolver(type => sp.GetService(type))));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ImobiliariaContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphiQl();
            app.UseMvc();
            db.EnsureSeedData();
        }
    }
}
