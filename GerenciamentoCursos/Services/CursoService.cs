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
        public Curso FindById(int id)
        {
            return _context.Curso.FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Curso.Find(id);
            _context.Curso.Remove(obj);
            _context.SaveChanges();
        }      
    }
}
