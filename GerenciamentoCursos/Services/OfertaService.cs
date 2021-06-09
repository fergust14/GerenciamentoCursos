using GerenciamentoCursos.Data;
using GerenciamentoCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoCursos.Services
{
    public class OfertaService
    {
        private readonly GerenciamentoCursosContext _context;

        public OfertaService(GerenciamentoCursosContext context)
        {
            _context = context;
        }
        public List<Oferta> FindAll()
        {
            return _context.Oferta.ToList();
        }
    }
}
