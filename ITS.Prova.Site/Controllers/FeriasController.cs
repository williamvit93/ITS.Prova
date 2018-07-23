using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ITS.Prova.Site.Models;
using Newtonsoft.Json;

namespace ITS.Prova.Site.Controllers
{
    public class FeriasController : BaseController
    {
        private const string Uri = "api/Ferias/";

        [HttpGet]
        public ActionResult Index()
        {
            var response = GetAllResponseMessage(Uri);
            if (response.IsSuccessStatusCode)
            {
                var funcionariosFeriasViewModel = JsonConvert.DeserializeObject<IEnumerable<FuncionarioFeriasViewModel>>(GetResults(response));

                return View(funcionariosFeriasViewModel);
            }
            return View("Error");
        }

        public ActionResult Create()
        {
            var funcionariosFeriasViewModel = new FuncionarioFeriasViewModel()
            {
                Funcionarios = JsonConvert.DeserializeObject<IEnumerable<FuncionarioViewModel>>(GetResults(GetAllResponseMessage("api/Funcionarios/")))
            };

            return View(funcionariosFeriasViewModel);
        }

        [HttpPost]
        public ActionResult Create(FuncionarioFeriasViewModel funcionarioFeriasViewModel)
        {
            if (PostResponseMessage(funcionarioFeriasViewModel, Uri).IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View("Error");
        }

        public ActionResult Edit(int id)
        {
            var response = GetResponseMessage(Uri, id);
            if (response.IsSuccessStatusCode)
            {
                var funcionarioFeriasViewModel =
                    JsonConvert.DeserializeObject<FuncionarioFeriasViewModel>(GetResults(response));

                funcionarioFeriasViewModel.Funcionarios =
                    JsonConvert.DeserializeObject<IEnumerable<FuncionarioViewModel>>(
                        GetResults(GetAllResponseMessage("api/Funcionarios/")));

                return View(funcionarioFeriasViewModel);
            }

            return View("Error");
        }

        [HttpPost]
        public ActionResult Edit(FuncionarioFeriasViewModel funcionarioFeriasViewModel)
        {
            if (PutResponseMessage(funcionarioFeriasViewModel, Uri).IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View("Error");
        }

        public ActionResult Delete(int id)
        {
            if (DeleteResponseMessage(Uri, id).IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View("Error");
        }

    }
}