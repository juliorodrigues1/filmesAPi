using FilmeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmeApi.Data;

public class FilmeApiContext : DbContext
{
    
    public FilmeApiContext(DbContextOptions<FilmeApiContext> options) : base(options)
    {
    }

    public DbSet<FilmeModel> Filmes { get; set; }
    public DbSet<CinemaModel> Cinemas { get; set; }
    public DbSet<EnderecoModel> Enderecos { get; set; }
    public DbSet<SessaoModel> Sessoes { get; set; }
}