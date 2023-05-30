using AutoMapper;
using FilmeApi.Data;
using FilmeApi.Data.Dtos;
using FilmeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private FilmeApiContext _filmeApiContext;
    private IMapper _mapper;

    public FilmeController(FilmeApiContext filmeApiContext, IMapper mapper)
    {
        _filmeApiContext = filmeApiContext;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult create([FromBody] CreateFilmeDto filmeDto)
    {
        FilmeModel filme = _mapper.Map<FilmeModel>(filmeDto);
        _filmeApiContext.Filmes.Add(filme);
        _filmeApiContext.SaveChanges();
        return CreatedAtAction(nameof(findById), new { id = filme.id }, filme);
    }
    
    [HttpGet]
    public IEnumerable<ReadFilmeDto> findAll([FromQuery]int skip = 0, [FromQuery]int take = 10)
    {
        return _mapper.Map<List<ReadFilmeDto>>(_filmeApiContext.Filmes.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult findById(int id)
    {
        var filme = _filmeApiContext.Filmes.FirstOrDefault(filme => filme.id == id);
        if (filme == null) return NotFound();
        var filmeDto = _mapper.Map<ReadFilmeDto>(filme);
        return Ok(filmeDto);

    }

    [HttpPut("{id}")]
    public IActionResult update(int id, [FromBody] UpdateFilmeDto filmeDto)
    {
        var filme = _filmeApiContext.Filmes.FirstOrDefault(filme => filme.id == id);
        if (filme == null) return NotFound();

        _mapper.Map(filmeDto, filme);
        _filmeApiContext.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult delete(int id)
    {
        var filme = _filmeApiContext.Filmes.FirstOrDefault(filme => filme.id == id);
        if (filme == null) return NotFound();

        _filmeApiContext.Filmes.Remove(filme);
        _filmeApiContext.SaveChanges();
        return NoContent();
    }
}