using System.Collections.Generic;
using ITS.Prova.Domain.Funcionario;

namespace ITS.Prova.Data.Interfaces
{
    public interface IFuncionarioFeriasRepository
    {
        void Add(FuncionarioFerias funcionarioFerias);
        void Update(FuncionarioFerias funcionarioFerias);
        void Delete(FuncionarioFerias funcionarioFerias);
        void Commit();
        FuncionarioFerias GetById(int funcionarioId);
        IEnumerable<FuncionarioFerias> GetAll();
    }
}
