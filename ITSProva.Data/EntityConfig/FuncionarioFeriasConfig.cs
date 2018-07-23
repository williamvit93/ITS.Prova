using System.Data.Entity.ModelConfiguration;
using ITS.Prova.Domain.Funcionario;

namespace ITSProva.Data.EntityConfig
{
    public class FuncionarioFeriasConfig : EntityTypeConfiguration<FuncionarioFerias>
    {
        public FuncionarioFeriasConfig()
        {
            HasKey(x => x.FeriasId);

            HasRequired(x => x.Funcionario)
                .WithMany(x => x.FuncionarioFerias)
                .HasForeignKey(x => x.FuncionarioId);

            ToTable("Ferias");
        }
    }
}
