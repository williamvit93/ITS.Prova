using System;
using System.Collections.Generic;
using ITS.Prova.Domain.Funcionario;

namespace ITSProva.Data.Interfaces
{
    public interface IFuncionarioFeriasRepository
    {
        void Add(FuncionarioFerias funcionarioFerias);
        void Update(FuncionarioFerias funcionarioFerias);
        void Delete(FuncionarioFerias funcionarioFerias);
        void Commit();
        FuncionarioFerias GetById(int feriasId);
        IEnumerable<FuncionarioFerias> GetAll();
    }
}
