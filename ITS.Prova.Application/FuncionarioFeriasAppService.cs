using System;
using System.Collections.Generic;
using AutoMapper;
using ITS.Prova.Application.Interfaces;
using ITS.Prova.Application.ViewModels;
using ITS.Prova.Domain.Funcionario;
using ITS.Prova.Domain.Interfaces;
using ITSProva.Data.Interfaces;

namespace ITS.Prova.Application
{
    public class FuncionarioFeriasAppService : IFuncionarioFeriasAppService
    {
        private readonly IFuncionarioFeriasService _funcionarioFeriasService;
        private readonly IFuncionarioFeriasRepository _funcionarioFeriasRepository;

        public FuncionarioFeriasAppService(IFuncionarioFeriasService funcionarioFeriasService, IFuncionarioFeriasRepository funcionarioFeriasRepository)
        {
            _funcionarioFeriasService = funcionarioFeriasService;
            _funcionarioFeriasRepository = funcionarioFeriasRepository;
        }

        public IEnumerable<FuncionarioFeriasViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<FuncionarioFeriasViewModel>>(_funcionarioFeriasRepository.GetAll());
        }

        public FuncionarioFeriasViewModel GetById(int id)
        {
            return Mapper.Map<FuncionarioFeriasViewModel>(_funcionarioFeriasRepository.GetById(id));
        }

        public void Register(FuncionarioFeriasViewModel funcionarioFeriasViewModel)
        {
            var funcionarioFerias = Mapper.Map<FuncionarioFerias>(funcionarioFeriasViewModel);
            _funcionarioFeriasService.Add(funcionarioFerias);
            if (true)
            {
                _funcionarioFeriasRepository.Commit();
            }
        }

        public void Update(FuncionarioFeriasViewModel funcionarioFeriasViewModel)
        {
            var funcionarioFerias = Mapper.Map<FuncionarioFerias>(funcionarioFeriasViewModel);
            _funcionarioFeriasService.Update(funcionarioFerias);
            if (true)
            {
                _funcionarioFeriasRepository.Commit();
            }
        }

        public void Delete(int id)
        {
            _funcionarioFeriasService.Delete(id);
            if (true)
            {
                _funcionarioFeriasRepository.Commit();
            }
        }
    }
}
