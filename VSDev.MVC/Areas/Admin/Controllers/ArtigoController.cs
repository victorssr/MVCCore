using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VSDev.MVC.Services.Interface;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VSDev.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArtigoController : Controller
    {
        private readonly IArtigoRepository _artigoRepository;

        public ArtigoController(IArtigoRepository artigoRepository)
        {
            _artigoRepository = artigoRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var artigo = _artigoRepository.ArtigoEmBranco();

            return View(artigo);
        }
    }
}
