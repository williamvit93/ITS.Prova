using ITS.Prova.Domain.Funcionario;
using ITS.Prova.Domain.Interfaces;
using ITSProva.Data.Interfaces;

namespace ITSProva.Data.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public void Add(Funcionario funcionario)
        {
            //Validar os dados
            _funcionarioRepository.Add(funcionario);
        }

        public void Delete(int id)
        {
            _funcionarioRepository.Delete(_funcionarioRepository.GetById(id));
        }

        public void Update(Funcionario funcionario)
        {
            _funcionarioRepository.Update(funcionario);
        }
    }
}
