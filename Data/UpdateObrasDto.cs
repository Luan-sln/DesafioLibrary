using System.ComponentModel.DataAnnotations;

namespace DesafioLibrary.Data
{
    public class UpdateObrasDto
    {
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public string FotoUrl { get; set; }
        public List<string> Autores { get; set; }
    }
}
