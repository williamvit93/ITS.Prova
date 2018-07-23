using System.Collections.Generic;
using System.Web.Http;
using ITS.Prova.Application.Interfaces;
using ITS.Prova.Application.ViewModels;

namespace ITS.Prova.API.Controllers
{
    public class FuncionariosController : ApiController
    {
        private readonly IFuncionarioAppService _funcionarioAppService;
        private readonly IFuncionarioFeriasAppService _funcionarioFeriasAppService;

        public FuncionariosController(IFuncionarioAppService funcionarioAppService, IFuncionarioFeriasAppService funcionarioFeriasAppService)
        {
            _funcionarioAppService = funcionarioAppService;
            _funcionarioFeriasAppService = funcionarioFeriasAppService;
        }

        [HttpGet]
        public IEnumerable<FuncionarioViewModel> ListarFuncionarios()
        {
            var listaFuncionariosViewModel = _funcionarioAppService.GetAllFuncionarios();
            return listaFuncionariosViewModel;
        }

        [HttpPost]
        public void NovoFuncionario(FuncionarioViewModel funcionarioViewModel)
        {
            _funcionarioAppService.NewFuncionario(funcionarioViewModel);
        }

        [HttpPut]
        public void AtualizaFuncionario(FuncionarioViewModel funcionarioViewModel)
        {
            _funcionarioAppService.UpdateFuncionario(funcionarioViewModel);
        }

        [HttpDelete]
        public void DeletaFuncionario(int id)
        {
            _funcionarioAppService.Delete(id);
        }

        [HttpGet]
        public FuncionarioViewModel BuscaFuncionarioPorId(int id)
        {
            return _funcionarioAppService.GetById(id);
        }
    }
}
