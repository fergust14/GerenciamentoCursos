using GerenciamentoCursos.Data;
using GerenciamentoCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoCursos.Services
{
    public class TipoService
    {
        private readonly GerenciamentoCursosContext _context;

        public TipoService(GerenciamentoCursosContext context)
        {
            _context = context;
        }
        public List<Tipo> FindAll()
        {
            return _context.Tipo.ToList();
        }
        public void Insert(Tipo obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
