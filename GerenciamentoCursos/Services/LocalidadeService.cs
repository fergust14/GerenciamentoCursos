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
        public Localidade FindById(int id)
        {
            return _context.Localidade.FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Localidade.Find(id);
            _context.Localidade.Remove(obj);
            _context.SaveChanges();
        }
    }
}

