using AutoMapper;
using FilmeApi.Data;
using FilmeApi.Data.Dtos;
using FilmeApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EnderecoController : ControllerBase
{
    private FilmeApiContext _context;
    private IMapper _mapper;

    public EnderecoController(FilmeApiContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult create([FromBody] CreateEnderecoDto enderecoDto)
    {
        EnderecoModel endereco = _mapper.Map<EnderecoModel>(enderecoDto);
        _context.Enderecos.Add(endereco);
        return CreatedAtAction(nameof(findById), new { id = endereco.id }, endereco);
    }

    [HttpGet("{id}")]
    public IActionResult findById(int id)
    {
        EnderecoModel endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.id == id);
        if (endereco == null) return NotFound();

        var filmeDto = _mapper.Map<ReadEnderecoDto>(endereco);
        return Ok(filmeDto);

    }

    [HttpGet]
    public IEnumerable<ReadEnderecoDto> findAll()
    {
        return _mapper.Map<List<ReadEnderecoDto>>(_context.Enderecos.ToString());
    }

    [HttpPut("{id}")]
    public IActionResult update(int id, [FromBody] UpdateEnderecoDto enderecoDto)
    {
        EnderecoModel endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.id == id);

        if (endereco == null) return NotFound();

        _mapper.Map(enderecoDto, endereco);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult delete(int id)
    {
        EnderecoModel endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.id == id);
        if (endereco == null) return NotFound();

        _context.Enderecos.Remove(endereco);
        _context.SaveChanges();
        return NoContent();
    }


}