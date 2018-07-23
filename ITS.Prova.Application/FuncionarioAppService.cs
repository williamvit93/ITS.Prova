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
    public class FuncionarioAppService : IFuncionarioAppService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IFuncionarioFeriasRepository _funcionarioFeriasRepository;
        private readonly IFuncionarioService _funcionarioService;
        private readonly IFuncionarioFeriasService _funcionarioFeriasService;

        public FuncionarioAppService(IFuncionarioRepository funcionarioRepository, IFuncionarioFeriasRepository funcionarioFeriasRepository, IFuncionarioService funcionarioService, IFuncionarioFeriasService funcionarioFeriasService)
        {
            _funcionarioRepository = funcionarioRepository;
            _funcionarioFeriasRepository = funcionarioFeriasRepository;
            _funcionarioService = funcionarioService;
            _funcionarioFeriasService = funcionarioFeriasService;
        }

        public IEnumerable<FuncionarioViewModel> GetAllFuncionarios()
        {
            return Mapper.Map<IEnumerable<FuncionarioViewModel>>(_funcionarioRepository.GetAll());
        }

        public void NewFuncionario(FuncionarioViewModel funcionarioViewModel)
        {
            var funcionario = Mapper.Map<Funcionario>(funcionarioViewModel);
            _funcionarioService.Add(funcionario);

            if (true)
            {
                _funcionarioRepository.Commit();
            }
        }

        public void UpdateFuncionario(FuncionarioViewModel funcionarioViewModel)
        {
            var funcionario = Mapper.Map<Funcionario>(funcionarioViewModel);
            _funcionarioService.Update(funcionario);
            if (true) _funcionarioRepository.Commit();
        }

        public void Delete(int id)
        {
            _funcionarioService.Delete(id);
            if (true) _funcionarioRepository.Commit();

        }

        public FuncionarioViewModel GetById(int id)
        {
            return Mapper.Map<FuncionarioViewModel>(_funcionarioRepository.GetById(id));
        }
    }
}
