using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoCursos.Models.ViewModels
{
    public class OfertaFormViewModel
    {        
        public Oferta Oferta { get; set; }
        public ICollection<Localidade> Localidades { get; set; }
        public ICollection<Curso> Cursos { get; set; }
        public string Status { get; set; }
    }
}
