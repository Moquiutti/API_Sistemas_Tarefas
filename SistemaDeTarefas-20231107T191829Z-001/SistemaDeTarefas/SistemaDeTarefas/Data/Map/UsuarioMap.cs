using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuárioModel> 
    {
        public void Configure(EntityTypeBuilder<UsuárioModel> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.nome).IsRequired().HasMaxLength(225);
            builder.Property(x => x.email).IsRequired().HasMaxLength(150);
        }
    }
    
}
