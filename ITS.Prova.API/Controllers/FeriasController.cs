using System;
using System.Collections.Generic;
using System.Web.Http;
using ITS.Prova.Application.Interfaces;
using ITS.Prova.Application.ViewModels;

namespace ITS.Prova.API.Controllers
{
    public class FeriasController : ApiController
    {
        private readonly IFuncionarioFeriasAppService _funcionarioFeriasAppService;

        public FeriasController(IFuncionarioFeriasAppService funcionarioFeriasAppService)
        {
            _funcionarioFeriasAppService = funcionarioFeriasAppService;
        }

        [HttpGet]
        public IEnumerable<FuncionarioFeriasViewModel> ListaFerias()
        {
            return _funcionarioFeriasAppService.GetAll();
        }


        [HttpPost]
        public void RegistrarFerias(FuncionarioFeriasViewModel funcionarioFeriasViewModel)
        {
            _funcionarioFeriasAppService.Register(funcionarioFeriasViewModel);
        }

        [HttpPut]
        public void AtualizarFerias(FuncionarioFeriasViewModel funcionarioFeriasViewModel)
        {
            _funcionarioFeriasAppService.Update(funcionarioFeriasViewModel);
        }


        [HttpDelete]
        public void DeletaFerias(int id)
        {
            _funcionarioFeriasAppService.Delete(id);
        }

        [HttpGet]
        public FuncionarioFeriasViewModel BuscaFeriasPorIdFuncionario(int id)
        {
            return _funcionarioFeriasAppService.GetById(id);
        }
    }
}
