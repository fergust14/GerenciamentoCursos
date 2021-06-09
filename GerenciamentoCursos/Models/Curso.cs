using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciamentoCursos.Models.Enums;

namespace GerenciamentoCursos.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Oferta> Disponibilidade { get; set; } = new List<Oferta>();
        public Tipos Tipo { get; set; }

        public Curso()
        {

        }
        public Curso(int id, string nome, Tipos tipo)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
        }

        public void AdicionarOferta(Oferta oferta)
        {
            Disponibilidade.Add(oferta);
        }
        public void RemoverOferta(Oferta oferta)
        {
            Disponibilidade.Remove(oferta);
        }
    }
}
