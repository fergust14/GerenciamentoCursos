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

namespace GerenciamentoCursos.Controllers
{
    public class OfertasController : Controller
    {
        private readonly OfertaService _ofertaService;

        public OfertasController(OfertaService ofertaService)
        {
            _ofertaService = ofertaService;
        }
        public IActionResult Index()
        {
            var list = _ofertaService.FindAll();

            return View(list);
        }
    }
}
