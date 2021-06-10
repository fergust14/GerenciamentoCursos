using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoCursos.Models
{
    public class Oferta
    {
        public int Id { get; set; }
        public Localidade Localidade { get; set; }
        public int LocalidadeId { get; set; }
        public Curso Curso { get; set; }
        public int CursoId { get; set; }
        public string Status { get; set; }

        public Oferta()
        {

        }
        public Oferta(int id, Localidade localidade, Curso curso, string status)
        {
            Id = id;
            Localidade = localidade;
            Curso = curso;
            Status = status;
        }
    }
}