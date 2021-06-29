using Imobiliaria.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Imobiliaria.DataBase
{
    public static class ImobiliariaSeedData
    {
        public static void EnsureSeedData(this ImobiliariaContext db) 
        {
            if (!db.Imoveis.Any() || db.Pagamentos.Any())
            {
                var imoveis = new List<Imovel>
                {
                    new Imovel
                    {
                        Cidade = "Belo Horizonte",
                        Familia = "Adams",
                        Logradouro = "Rua das travessuras 113",
                        Nome = "Casa Escura",
                        Preco = 260000,
                        Pagamentos = new List<Pagamento>
                        {
                            new Pagamento
                            {
                                DataCriacao = new DateTime(2019, 08, 01),
                                DataVencimento = new DateTime(2019, 08, 15),
                                Valor = 1500,
                                Paga = true
                            },
                            new Pagamento
                            {
                                DataCriacao = new DateTime(2019, 09, 01),
                                DataVencimento = new DateTime(2019, 09, 15),
                                Valor = 1500,
                                Paga = true
                            },
                            new Pagamento
                            {
                                DataCriacao = new DateTime(2019, 10, 01),
                                DataVencimento = new DateTime(2019, 10, 15),
                                Valor = 1500,
                                Paga = true
                            }
                        }
                    },
                    new Imovel
                    {
                        Cidade = "São Paulo",
                        Familia = "Silova",
                        Logradouro = "Rua Padre Pedro Pinto 113",
                        Nome = "Casa Amarela",
                        Preco = 150000,
                        Pagamentos = new List<Pagamento>
                        {
                            new Pagamento
                            {
                                DataCriacao = new DateTime(2019, 08, 01),
                                DataVencimento = new DateTime(2019, 08, 15),
                                Valor = 2500,
                                Paga = true
                            },
                            new Pagamento
                            {
                                DataCriacao = new DateTime(2019, 09, 01),
                                DataVencimento = new DateTime(2019, 09, 15),
                                Valor = 1500,
                                Paga = false
                            },
                            new Pagamento
                            {
                                DataCriacao = new DateTime(2019, 10, 01),
                                DataVencimento = new DateTime(2019, 10, 15),
                                Valor = 2500,
                                Paga = false
                            }
                        }
                    },
                    new Imovel
                    {
                        Cidade = "Curitiba",
                        Familia = "Souza",
                        Logradouro = "Avenida dos canarios 1500",
                        Nome = "Casa Verde",
                        Preco = 300000,
                        Pagamentos = new List<Pagamento>
                        {
                            new Pagamento
                            {
                                DataCriacao = new DateTime(2019, 08, 01),
                                DataVencimento = new DateTime(2019, 08, 15),
                                Valor = 3000,
                                Paga = true
                            },
                            new Pagamento
                            {
                                DataCriacao = new DateTime(2019, 09, 01),
                                DataVencimento = new DateTime(2019, 09, 15),
                                Valor = 3000,
                                Paga = true
                            },
                            new Pagamento
                            {
                                DataCriacao = new DateTime(2019, 10, 01),
                                DataVencimento = new DateTime(2019, 10, 15),
                                Valor = 3000,
                                Paga = false
                            }
                        }
                    }
                };

                db.Imoveis.AddRange(imoveis);
                db.SaveChanges();
            }        
        }
    }
}
