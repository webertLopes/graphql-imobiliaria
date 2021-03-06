// <auto-generated />
using System;
using Imobiliaria.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Imobiliaria.DataBase.Migrations
{
    [DbContext(typeof(ImobiliariaContext))]
    partial class ImobiliariaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Imobiliaria.DataBase.Models.Imovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cidade");

                    b.Property<string>("Familia");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("Id");

                    b.ToTable("Imoveis");
                });

            modelBuilder.Entity("Imobiliaria.DataBase.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataVencimento");

                    b.Property<int>("ImovelId");

                    b.Property<bool>("Paga");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("ImovelId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("Imobiliaria.DataBase.Models.Pagamento", b =>
                {
                    b.HasOne("Imobiliaria.DataBase.Models.Imovel", "Imovel")
                        .WithMany("Pagamentos")
                        .HasForeignKey("ImovelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
