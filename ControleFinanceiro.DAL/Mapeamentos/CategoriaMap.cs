using ControleFinenceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mapeamentos
{
    class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c  => c.CategoriaId);//Chave Primaria
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);//Nome
            builder.Property(c => c.Icone).IsRequired().HasMaxLength(15);//Nome

            builder.HasOne(c => c.Tipo).WithMany(c => c.Categorias).HasForeignKey(c => c.TipoId).IsRequired() ;//Chave extrange
            builder.HasMany(c => c.Ganhos).WithOne(c => c.Categoria);//Chave extrange
            builder.HasMany(c => c.Despesas).WithOne(c => c.Categoria);//Chave extrange


            builder.ToTable("Categorias");
        }
    }
}
