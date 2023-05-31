namespace FilmeApi.Data.Dtos;

public class ReadFilmeDto
{
    
    public string titulo { get; set; }
    public string genero { get; set; }
    public int duracao { get; set; }
    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
    public ICollection<ReadSessaoDto> sessoes { get; set; }
}