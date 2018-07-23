using System.Data.Entity.ModelConfiguration;
using ITS.Prova.Domain.Funcionario;

namespace ITS.Prova.Data.EntityConfig
{
    public class FuncionarioConfig : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfig()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("FuncionarioId");
            HasRequired(x => x.FuncionarioFerias).WithRequiredPrincipal(x => x.Funcionario);

        }
    }
}
