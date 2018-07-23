using System.Collections.Generic;
using ITS.Prova.Application.ViewModels;

namespace ITS.Prova.Application.Interfaces
{
    public interface IFuncionarioAppService
    {
        IEnumerable<FuncionarioViewModel> GetAllFuncionarios();
        void NewFuncionario(FuncionarioViewModel funcionarioViewModel);
        void UpdateFuncionario(FuncionarioViewModel funcionarioViewModel);
        void Delete(int id);
        FuncionarioViewModel GetById(int id);
    }
}
