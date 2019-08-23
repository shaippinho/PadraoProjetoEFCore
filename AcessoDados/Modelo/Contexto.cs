using Microsoft.EntityFrameworkCore;
using Dominio.Entidades;
using System;

namespace AcessoDados.Modelo
{
    public class Contexto : DbContext
    {


        public Contexto()
        { }

        public Contexto(DbContextOptions<Contexto> opcoes)
            : base(opcoes)
        { }

        public DbSet<Teste> Testes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                //@"data source=.;Database=TesteEFCore; user id=sa;password=desenv123!;", 
                "Data Source=localhost;Initial Catalog=TesteEFCore;Integrated Security=False;User ID=sa;Password=desenv123!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False",
                builder => 
                                        {
                                            builder.EnableRetryOnFailure(5,TimeSpan.FromSeconds(10), null);
                                        });

            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder construtorDeModelos)
        {
            Mapeamento.TesteMap.ConfiguraClasseTeste(construtorDeModelos);
        }

       
    }
}