using GerenciamentoCursos.Data;
using GerenciamentoCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoCursos.Services
{
    public class CursoService
    {
        private readonly GerenciamentoCursosContext _context;

        public CursoService(GerenciamentoCursosContext context)
        {
            _context = context;
        }
        public List<Curso> FindAll()
        {
            return _context.Curso.ToList();
        }

        internal void Insert(Curso obj)
        {            
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
