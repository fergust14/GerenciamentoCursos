using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoCursos.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }        
        public Tipo Tipo { get; set; }
        public int TipoId { get; set; }

        public Curso()
        {

        }
        public Curso(int id, string nome, Tipo tipo)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
        }
    }
}
