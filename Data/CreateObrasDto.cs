using System.ComponentModel.DataAnnotations;

namespace DesafioLibrary.Data
{
    public class CreateObrasDto
    {
        [Required(ErrorMessage = "Titulo é um campo obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Editora é um campo obrigatorio")]
        public string Editora { get; set; }
        public string FotoUrl { get; set; }
        [Required(ErrorMessage = "Autores é um campo obrigatorio")]
        public List<string> Autores { get; set; }
    }
}
