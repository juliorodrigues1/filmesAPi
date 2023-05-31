namespace FilmeApi.Data.Dtos;

public class ReadCinemaDto
{
    public int id { get; set; }
    public string nome { get; set; }
    public ReadEnderecoDto endereco { get; set; }
}