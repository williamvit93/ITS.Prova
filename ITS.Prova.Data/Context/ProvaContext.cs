using System.Data.Entity;
using ITS.Prova.Data.EntityConfig;
using ITS.Prova.Domain.Funcionario;

namespace ITS.Prova.Data.Context
{
    public class ProvaContext : DbContext
    {
        public virtual DbSet<Funcionario> Funcionario { get; set; }
        public virtual DbSet<FuncionarioFerias> FuncionarioFerias { get; set; }

        public ProvaContext()
            : base("name=Prova")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FuncionarioConfig());
            modelBuilder.Configurations.Add(new FuncionarioFeriasConfig());
        }


    }
}
