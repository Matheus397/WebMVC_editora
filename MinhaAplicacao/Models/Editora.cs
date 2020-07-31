using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAplicacao.Models
{
    public class Editora
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Editor(a)")]
        public string Nome { get; set; }

        [Display(Name = "Apresentação do Editor(a)")]
        public string Apresentacao { get; set; }

        public int CNPJ { get; set; }
    }
}
