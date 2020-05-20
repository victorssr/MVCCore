using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VSDev.MVC.Extensions;
using VSDev.MVC.Services.Interface;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VSDev.MVC.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class ArtigoController : Controller
    {
        private readonly IArtigoRepository _artigoRepository;

        public ArtigoController(IArtigoRepository artigoRepository)
        {
            _artigoRepository = artigoRepository;
        }

        // CUSTOM AUTHORIZATION WITH ROLE CLAIMS
        [CustomAuthorization("Artigo", "Index")]
        public IActionResult Index()
        {
            var artigo = _artigoRepository.ArtigoEmBranco();

            return View(artigo);
        }

        // AUTHORIZATION WITH ROLES
        [Authorize(Roles = "Admin")]
        public IActionResult Novo()
        {
            return View();
        }

        // AUTHORIZATION WITH POLICY CLAIMS
        [Authorize(Policy = "PodeExcluir")]
        public IActionResult Excluir()
        {
            return View();
        }

    }
}
