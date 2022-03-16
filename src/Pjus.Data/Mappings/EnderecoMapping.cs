using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pjus.Business.Models;

namespace Pjus.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Cep)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(c => c.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Complemento)
                .HasColumnType("varchar(250)");

            builder.Property(c => c.Bairro)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Localidade)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.UF)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Ibge)
                .IsRequired()
                .HasColumnType("varchar(7)");

            builder.Property(c => c.Gia)
                .IsRequired()
                .HasColumnType("varchar(4)");

            builder.Property(c => c.DDD)
                .IsRequired()
                .HasColumnType("varchar(2)");

            builder.Property(c => c.Siafi)
                .IsRequired()
                .HasColumnType("varchar(4)");

            builder.ToTable("Enderecos");
        }
    }
}
