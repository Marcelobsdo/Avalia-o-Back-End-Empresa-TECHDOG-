using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TD_ApplicationCore.Entity;

namespace TD_Infrastructure.EntityConfig
{
    public class EscolaMap : IEntityTypeConfiguration<Escola>
    {
        public void Configure(EntityTypeBuilder<Escola> builder)
        {
            builder.HasKey(e => e.Id);

            builder.OwnsOne(e => e.Endereco);

            builder.OwnsOne(e => e.Endereco).Property(p => p.Logradouro).HasColumnName("Logradouro");
            builder.OwnsOne(e => e.Endereco).Property(p => p.Complemento).HasColumnName("Complemento");
            builder.OwnsOne(e => e.Endereco).Property(p => p.Bairro).HasColumnName("Bairro");
            builder.OwnsOne(e => e.Endereco).Property(p => p.Cidade).HasColumnName("Cidade");
            builder.OwnsOne(e => e.Endereco).Property(p => p.Estado).HasColumnName("Estado");
            
        }
    }
}