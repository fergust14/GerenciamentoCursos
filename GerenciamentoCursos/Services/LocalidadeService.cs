using GerenciamentoCursos.Data;
using GerenciamentoCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoCursos.Services
{
    public class LocalidadeService
    {
        private readonly GerenciamentoCursosContext _context;

        public LocalidadeService(GerenciamentoCursosContext context)
        {
            _context = context;
        }
        public List<Localidade> FindAll()
        {
            return _context.Localidade.ToList();
        }
        public void Insert(Localidade obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}

