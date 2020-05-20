using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VSDev.MVC.Models;

namespace VSDev.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/Erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var model = new ErrorViewModel();

            if (id == 500)
            {
                model.Titulo = "Ops! Ocorreu um erro";
                model.Descricao = "Por favor, contate o suporte.";
                model.StatusCode = id;
            }
            else if (id == 404)
            {
                model.Titulo = "Ops! Página não encontrada";
                model.Descricao = "A página que está procurando não existe. Em caso de dúvidas entre em contato com o nosso suporte.";
                model.StatusCode = id;
            }
            else if(id == 403)
            {
                model.Titulo = "Ops! Acesso negado";
                model.Descricao = "Você não tem permissão para prosseguir.";
            }
            else
            {
                return StatusCode(500);
            }

            return View(model);
        }
    }
}
