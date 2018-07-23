using System;

namespace ITS.Prova.Application.ViewModels
{
    public class FuncionarioViewModel
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime? DataDemissao { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}