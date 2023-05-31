using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Data.Dtos;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "O campo nome é obrigatório")] 
    public string nome { get; set; }
}