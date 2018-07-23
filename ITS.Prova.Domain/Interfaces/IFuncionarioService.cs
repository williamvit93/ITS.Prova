namespace ITS.Prova.Domain.Interfaces
{
    public interface IFuncionarioService
    {
        void Add(Funcionario.Funcionario funcionario);
        void Delete(int id);
        void Update(Funcionario.Funcionario funcionario);
    }
}
