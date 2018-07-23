using System;
using System.Collections.Generic;

namespace ITS.Prova.Domain.Funcionario
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string NomeCompleto { get; private set; }
        public string Rg { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public DateTime? DataDemissao { get; private set; }
        public DateTime DataAdmissao { get; private set; }
        public virtual ICollection<FuncionarioFerias> FuncionarioFerias { get; set; }

        protected Funcionario()
        {
            
        }

        public Funcionario(string nomeCompleto, string rg, string cpf, DateTime dataNascimento, DateTime dataAdmissao)
        {
            NomeCompleto = nomeCompleto;
            Rg = rg;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            DataAdmissao = dataAdmissao;
        }

        private void RegistrarDemissao()
        {
            DataDemissao = DateTime.Now;
        }
    }
}
