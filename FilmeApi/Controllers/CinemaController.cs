using AutoMapper;
using FilmeApi.Data;
using FilmeApi.Data.Dtos;
using FilmeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CinemaController : ControllerBase
{
    private FilmeApiContext _context;
    private IMapper _mapper;

    public CinemaController(FilmeApiContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult create([FromBody] CreateCinemaDto cinemaDto)
    {
        CinemaModel cinema = _mapper.Map<CinemaModel>(cinemaDto);
        _context.Cinemas.Add(cinema);
        _context.SaveChanges();
        return CreatedAtAction(nameof(findById), new { id = cinema.id }, cinema);
    }

    [HttpGet("{id}")]
    public IActionResult findById(int id)
    {
        CinemaModel cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.id == id);
        if (cinema == null) return NotFound();

        return Ok(cinema);
    }

    [HttpGet]
    public IEnumerable<ReadCinemaDto> findAll()
    {
        return _mapper.Map<List<ReadCinemaDto>>(_context.Cinemas.ToList());
    }

    [HttpPut("{id}")]
    public IActionResult update(int id, [FromBody] UpdateCinemaDto cinemaDto)
    {
        CinemaModel cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.id == id);
        if (cinema == null) return NotFound();

        _mapper.Map(cinemaDto, cinema);
        _context.SaveChanges();
        return NoContent();

    }

    [HttpDelete("{id}")]
    public IActionResult delete(int id)
    {
        CinemaModel cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.id == id);
        if (cinema == null) return NotFound();

        _context.Cinemas.Remove(cinema);
        _context.SaveChanges();
        return NoContent();
    }
}