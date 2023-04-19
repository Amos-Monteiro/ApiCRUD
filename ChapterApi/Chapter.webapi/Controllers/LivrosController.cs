using Chapter.webapi.Models;
using Chapter.webapi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
namespace Chapter.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly LivrosRepository _livroRepository;
        public LivrosController(LivrosRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_livroRepository.Listar());
        }
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Livro livro = _livroRepository.BuscaPorId(id);
            if (livro==null)
            {
                return NotFound();
            }
            return Ok(livro);
        }
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id,Livro livro) 
        {
            _livroRepository.Atualizar(id, livro);
            return StatusCode(204);
        }
        [HttpPost]
        public IActionResult Cadastrar(Livro livro)
        {
            _livroRepository.Cdastrar(livro);
            return StatusCode(201);
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _livroRepository.Deletar(id);
            return StatusCode(204);
        }
    }
    

}