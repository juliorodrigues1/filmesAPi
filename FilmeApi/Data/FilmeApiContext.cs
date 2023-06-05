using FilmeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmeApi.Data;

public class FilmeApiContext : DbContext
{
    
    public FilmeApiContext(DbContextOptions<FilmeApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<SessaoModel>()
            .HasKey(sessao => new { sessao.filmeId, sessao.CinemaId });

        builder.Entity<SessaoModel>()
            .HasOne(sessao => sessao.Cinema)
            .WithMany(cinema => cinema.Sessoes)
            .HasForeignKey(sesao => sesao.CinemaId);

        builder.Entity<SessaoModel>()
            .HasOne(sessao => sessao.Filme)
            .WithMany(filme => filme.Sessoes)
            .HasForeignKey(sesao => sesao.filmeId);
    }

    public DbSet<FilmeModel> Filmes { get; set; }
    public DbSet<CinemaModel> Cinemas { get; set; }
    public DbSet<EnderecoModel> Enderecos { get; set; }
    public DbSet<SessaoModel> Sessoes { get; set; }
}