using System.Collections.Generic;
using ITS.Prova.Domain.Funcionario;

namespace ITS.Prova.Data.Interfaces
{
    public interface IFuncionarioRepository
    {
        void Add(Funcionario funcionario);
        void Update(Funcionario funcionario);
        void Delete(Funcionario funcionario);
        void Commit();
        Funcionario GetById(int funcionarioId);
        IEnumerable<Funcionario> GetAll();
    }
}
