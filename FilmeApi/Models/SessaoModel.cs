using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Models;

public class SessaoModel
{
    [Key]
    [Required]
    public int id { get; set; }
    
    [Required]
    public int filmeId { get; set; }
    public virtual FilmeModel Filme { get; set; }
    
    public int? CinemaId { get; set; }
    public virtual CinemaModel Cinema { get; set; }
    
}