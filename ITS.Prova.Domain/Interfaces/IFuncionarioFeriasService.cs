using System;
using ITS.Prova.Domain.Funcionario;

namespace ITS.Prova.Domain.Interfaces
{
    public interface IFuncionarioFeriasService
    {
        void Add(FuncionarioFerias funcionarioFerias);
        void Update(FuncionarioFerias funcionarioFerias);
        void Delete(int id);
    }
}
