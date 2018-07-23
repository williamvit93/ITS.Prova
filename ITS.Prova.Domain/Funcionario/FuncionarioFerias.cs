using System;

namespace ITS.Prova.Domain.Funcionario
{
    public class FuncionarioFerias
    {
        public int FeriasId { get; private set; }
        public int FuncionarioId { get; private set; }
        public virtual Funcionario Funcionario { get; set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataTermino { get; private set; }

        protected FuncionarioFerias()
        {
            
        }

        public FuncionarioFerias(int feriasId, int funcionarioId, DateTime dataInicio, DateTime dataTermino)
        {
            FeriasId = feriasId;
            FuncionarioId = funcionarioId;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
        }
    }
}
