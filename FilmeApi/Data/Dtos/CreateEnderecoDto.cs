using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Data.Dtos;

public class CreateEnderecoDto
{
    [Required(ErrorMessage = "O Campo logradouro é obrigatorio")]
    public string logradouro { get; set; }
    [Required(ErrorMessage = "O Campo número é obrigatorio")]
    public int numero { get; set; }
}