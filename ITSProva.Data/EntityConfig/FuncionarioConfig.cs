using System.Data.Entity.ModelConfiguration;
using ITS.Prova.Domain.Funcionario;

namespace ITSProva.Data.EntityConfig
{
    public class FuncionarioConfig : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfig()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("FuncionarioId");
        }
    }
}
