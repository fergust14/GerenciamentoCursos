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
    public class OfertasController : Controller
    {
        private readonly OfertaService _ofertaService;
        private readonly CursoService _cursoService;
        private readonly LocalidadeService _localidadeService;
        public OfertasController(OfertaService ofertaService, CursoService cursoService, LocalidadeService localidadeService)
        {
            _ofertaService = ofertaService;
            _cursoService = cursoService;
            _localidadeService = localidadeService;
        }
        public IActionResult Index()
        {
            var list = _ofertaService.FindAll();

            return View(list);
        }
        public IActionResult Create()
        {
            var cursos = _cursoService.FindAll();
            var localidades = _localidadeService.FindAll();
            var viewModel1 = new OfertaFormViewModel
            {
                Localidades = localidades,
                Cursos = cursos                
            };            
            return View(viewModel1);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Oferta oferta)
        {
            _ofertaService.Insert(oferta);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _ofertaService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _ofertaService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
