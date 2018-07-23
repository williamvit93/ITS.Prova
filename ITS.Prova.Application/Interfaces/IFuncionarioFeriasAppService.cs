using System;
using System.Collections.Generic;
using ITS.Prova.Application.ViewModels;

namespace ITS.Prova.Application.Interfaces
{
    public interface IFuncionarioFeriasAppService
    {
        IEnumerable<FuncionarioFeriasViewModel> GetAll();
        FuncionarioFeriasViewModel GetById(int id);
        void Register(FuncionarioFeriasViewModel funcionarioFeriasViewModel);
        void Update(FuncionarioFeriasViewModel funcionarioFeriasViewModel);
        void Delete(int id);
    }
}
