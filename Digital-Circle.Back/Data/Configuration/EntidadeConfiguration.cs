using Digital_Circle.Back.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Digital_Circle.Back.Data.Configuration
{
    public class EntidadeConfiguration : IEntityTypeConfiguration<Entidade>
    {
        public void Configure(EntityTypeBuilder<Entidade> builder)
        {
            builder.ToTable("TB01");

            builder.Property(t => t.Id).HasColumnName("Id").ValueGeneratedOnAdd();

            builder.Property(t => t.Texto).HasColumnName("col_texto").HasColumnType("TEXT");

            builder.Property(t => t.Data).HasColumnName("col_dt").HasColumnType("TIMESTAMP");

            builder.HasKey(t => t.Id);
        }
    }
}
