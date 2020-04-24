using ProjetoAvanadeCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoAvanadeCliente.Controllers
{
    public class HomeController : Controller
    {
        //Construindo objeto Json

        [HttpGet]
        public ActionResult Index()
        {
            var cliente = new Cliente();
            cliente.Id = 12;
            cliente.Nome = "Aline";
            cliente.Salvar();

           

            
            ViewBag.cliente = cliente;

            return View();

        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            return Json(Cliente.Busca().Where(c => c.Id == id).First(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Criar()
        {
            var cliente = new Cliente();
                cliente.Id = 001;
                cliente.Nome = Request["Nome"];
                cliente.Agencia = Convert.ToInt32(Request["Numero da Agencia"]);
                cliente.ContaCorrente = Convert.ToInt32(Request["Numero da Conta Corrente"]);
                cliente.Senha = Convert.ToInt32(Request["Senha"]);
                cliente.Salvar();
               
                return Json(cliente);
            
        }


        [HttpPut]
        public ActionResult Alterar(int id)
        {
            var cliente = Cliente.Busca().Where(c => c.Id == id).First();
            // Request.QueryString
            // Request.Params["nome"]
            cliente.Nome = Request["Nome"];
            cliente.Agencia = Convert.ToInt32(Request["Telefone"]);
            return Json(cliente);
        }

    }
}
    