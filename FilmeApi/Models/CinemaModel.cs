using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Models;

public class CinemaModel
{
    [Key]
    [Required]
    public int id { get; set; }
    [Required(ErrorMessage = "O campo nome é obrigatório")] 
    public string nome { get; set; }
    public int enderecoId { get; set; }

    public virtual EnderecoModel Endereco { get; set; }
}