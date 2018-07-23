using System;
using System.Collections.Generic;

namespace ITS.Prova.Application.ViewModels
{
    public class FuncionarioFeriasViewModel
    {
        public int FuncionarioId { get; set; }
        public int FeriasId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public virtual FuncionarioViewModel Funcionario { get; set; }
        public virtual IEnumerable<FuncionarioViewModel> Funcionarios { get; set; }
    }
}