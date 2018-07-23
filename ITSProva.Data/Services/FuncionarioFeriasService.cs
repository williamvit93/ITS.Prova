using System;
using ITS.Prova.Domain.Funcionario;
using ITS.Prova.Domain.Interfaces;
using ITSProva.Data.Interfaces;

namespace ITSProva.Data.Services
{
    public class FuncionarioFeriasService : IFuncionarioFeriasService
    {
        private readonly IFuncionarioFeriasRepository _funcionarioFeriasRepository;

        public FuncionarioFeriasService(IFuncionarioFeriasRepository funcionarioFeriasRepository)
        {
            _funcionarioFeriasRepository = funcionarioFeriasRepository;
        }

        public void Add(FuncionarioFerias funcionarioFerias)
        {
            //TODO: Validar dados
            _funcionarioFeriasRepository.Add(funcionarioFerias);
        }

        public void Update(FuncionarioFerias funcionarioFerias)
        {
            //TODO: Validar dados
            _funcionarioFeriasRepository.Update(funcionarioFerias);
        }

        public void Delete(int id)
        {
            _funcionarioFeriasRepository.Delete(_funcionarioFeriasRepository.GetById(id));
        }
    }
}
