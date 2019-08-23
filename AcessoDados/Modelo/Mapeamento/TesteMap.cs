using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AcessoDados.Modelo.Mapeamento
{
    public class TesteMap
    {
        public static void ConfiguraClasseTeste(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<Teste>(etd =>
           {
               etd.ToTable("Teste");
               etd.HasKey(c => c.ID).HasName("id_teste");
               etd.Property(c => c.ID).HasColumnName("id_teste");
               etd.Property(c => c.Valor).HasColumnName("ds_valor").HasMaxLength(100);
           });
        }
    }
}