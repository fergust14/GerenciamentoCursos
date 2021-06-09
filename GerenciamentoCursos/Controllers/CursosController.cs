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
    public class CursosController : Controller
    {
        private readonly CursoService _cursoService;
        private readonly TipoService _tipoService;

        public CursosController(CursoService cursoService, TipoService tipoService)
        {
            _cursoService = cursoService;
            _tipoService = tipoService;
        }
        public IActionResult Index()
        {
            var list = _cursoService.FindAll();

            return View(list);
        }
        public IActionResult Create()
        {
            var tipos = _tipoService.FindAll();
            var viewModel = new CursoFormViewModel
            {
                Tipos = tipos
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Curso curso)
        {
            _cursoService.Insert(curso);
            return RedirectToAction(nameof(Index));
        }
    }
}
