using GerenciamentoCursos.Data;
using GerenciamentoCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoCursos.Services
{
    public class TiposService
    {
        private readonly GerenciamentoCursosContext _context;

        public TiposService(GerenciamentoCursosContext context)
        {
            _context = context;
        }
        public List<Tipos> FindAll()
        {
            return _context.Tipos.ToList();
        }
        public void Insert(Tipos obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
