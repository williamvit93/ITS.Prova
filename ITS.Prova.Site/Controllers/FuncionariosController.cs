using System.Collections.Generic;
using System.Web.Mvc;
using ITS.Prova.Site.Models;
using Newtonsoft.Json;

namespace ITS.Prova.Site.Controllers
{
    public class FuncionariosController : BaseController
    {
        private const string Uri = "api/Funcionarios/";

        [HttpGet]
        public ActionResult Index()
        {
            var response = GetAllResponseMessage(Uri);
            if (response.IsSuccessStatusCode)
            {
                var funcionariosViewModel =
                    JsonConvert.DeserializeObject<IEnumerable<FuncionarioViewModel>>(GetResults(response));

                return View(funcionariosViewModel);
            }

            return View("Error");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FuncionarioViewModel funcionarioViewModel)
        {
            if (PostResponseMessage(funcionarioViewModel, Uri).IsSuccessStatusCode)
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
                var funcionarioViewModel =
                    JsonConvert.DeserializeObject<FuncionarioViewModel>(GetResults(response));

                return View(funcionarioViewModel);
            }

            return View("Error");
        }

        [HttpPost]
        public ActionResult Edit(FuncionarioViewModel funcionarioViewModel)
        {
            if (PutResponseMessage(funcionarioViewModel, Uri).IsSuccessStatusCode)
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

        [HttpGet]
        public ActionResult Details(int id)
        {
            var response = GetResponseMessage(Uri, id);
            if (response.IsSuccessStatusCode)
            {
                var funcionarioViewModel =
                    JsonConvert.DeserializeObject<FuncionarioViewModel>(GetResults(response));

                return View(funcionarioViewModel);
            }

            return View("Error");
        }
    }
}