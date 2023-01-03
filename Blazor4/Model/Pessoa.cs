using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Blazor4.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Nome Obrigatório!")]
        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Documento Obrigatório!")]
        public string Documento { get; set; }
        [Range (1,5, ErrorMessage = "Número deve ser entre um a cinco.")]
        public int AnosNaEmpresa { get; set; }
        public DateTime? Aniversario { get; set; }

    }
}
