using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Models;

public class EnderecoModel
{
    [Key]
    [Required]
    public int id { get; set; }
    [Required(ErrorMessage = "O Campo logradouro é obrigatorio")]
    public string logradouro { get; set; }
    [Required(ErrorMessage = "O Campo número é obrigatorio")]
    public int numero { get; set; }

    public virtual CinemaModel Cinema { get; set; }
}