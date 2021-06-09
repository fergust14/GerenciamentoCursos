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
    public class TiposController : Controller
    {
        private readonly TipoService _tiposService;
        
        public TiposController(TipoService tiposService)
        {
            _tiposService = tiposService;           
        }
        public IActionResult Index()
        {
            var list = _tiposService.FindAll();

            return View(list);
        }
        public IActionResult Create()
        {
           return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tipo tipos)
        {
            _tiposService.Insert(tipos);
            return RedirectToAction(nameof(Index));
        }
    }
}
