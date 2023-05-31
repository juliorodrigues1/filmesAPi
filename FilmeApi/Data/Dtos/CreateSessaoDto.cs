using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Data.Dtos;

public class CreateSessaoDto
{
    [Required] 
    public int filmeID { get; set; }
    public int cinemaId { get; set; }
}