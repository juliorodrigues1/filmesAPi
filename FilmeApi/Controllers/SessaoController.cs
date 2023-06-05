using AutoMapper;
using FilmeApi.Data;
using FilmeApi.Data.Dtos;
using FilmeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmeApi.Controllers;


    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {
        private FilmeApiContext _context;
        private IMapper _mapper;

        public SessaoController(FilmeApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult create(CreateSessaoDto dto)
        {
            SessaoModel sessao = _mapper.Map<SessaoModel>(dto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(findById), new { filmeId = sessao.filmeId, cinemaId = sessao.CinemaId}, sessao);
        }

        [HttpGet]
        public IEnumerable<ReadSessaoDto> findAll()
        {
            return _mapper.Map<List<ReadSessaoDto>>(_context.Sessoes.ToList());
        }

        [HttpGet("{filmeID}/{cinemaID}")]
        public IActionResult findById(int filmeID, int cinemaID)
        {
            SessaoModel sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.filmeId == filmeID && sessao.CinemaId == cinemaID);
            if (sessao != null)
            {
                ReadSessaoDto sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);

                return Ok(sessaoDto);
            }
            return NotFound();
        }
    }
