using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Data.Dtos;

public class CreateFilmeDto
{
  
    [Required(ErrorMessage = "O título do filme é obrigatótio")]
    public string titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatótio")]
    [StringLength (50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string genero { get; set; }
    [Required(ErrorMessage = "a duração do filme é obrigatótio")]
    [Range(70, 600, ErrorMessage = "a duração deve ser entre 70 e 600 minutos")]
    public int duracao { get; set; }
}