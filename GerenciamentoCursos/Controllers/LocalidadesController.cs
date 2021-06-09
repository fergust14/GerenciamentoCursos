using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciamentoCursos.Data;
using GerenciamentoCursos.Models;
using GerenciamentoCursos.Services;
using GerenciamentoCursos.Models.ViewModels;

namespace GerenciamentoCursos.Controllers
{
    public class LocalidadesController : Controller
    {
        private readonly LocalidadeService _localidadeService;

        public LocalidadesController(LocalidadeService localidadeService)
        {
            _localidadeService = localidadeService;
        }
        public IActionResult Index()
        {
            var list = _localidadeService.FindAll();

            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Localidade localidade)
        {
            _localidadeService.Insert(localidade);
            return RedirectToAction(nameof(Index));
        }
    }
}
