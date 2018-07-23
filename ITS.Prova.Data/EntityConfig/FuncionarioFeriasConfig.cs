using System.Data.Entity.ModelConfiguration;
using ITS.Prova.Domain.Funcionario;

namespace ITS.Prova.Data.EntityConfig
{
    public class FuncionarioFeriasConfig : EntityTypeConfiguration<FuncionarioFerias>
    {
        public FuncionarioFeriasConfig()
        {
            HasKey(x => x.FuncionarioId);

            ToTable("Ferias");
        }
    }
}
