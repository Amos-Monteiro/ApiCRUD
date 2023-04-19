using Chapter.webapi.Context;
using Chapter.webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter.webapi.Repositories
{
    public class LivrosRepository
    {
        private readonly ChapterContext _context;
        public LivrosRepository(ChapterContext context)
        {
            _context = context;
        }
        public List<Livro> Listar(){
            return _context.Livros.ToList();
        }
        public Livro BuscaPorId(int id)
        {
            return _context.Livros.Find(id);
        }
        public void Atualizar(int id, Livro livro)
        {
            Livro livroBuscado= _context.Livros.Find(id);
            if(livroBuscado != null)
            {
                livroBuscado.Titulo = livro.Titulo;
                livroBuscado.QuantidadePaginas = livro.QuantidadePaginas;
                livroBuscado.Disponivel = livro.Disponivel;
            }
            _context.Livros.Update(livroBuscado);
            _context.SaveChanges();
        }
        public void Cdastrar(Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }
        public void Deletar(int id)
        {
            Livro livroBuscado = _context.Livros.Find(id);
            _context.Livros.Remove(livroBuscado);
            _context.SaveChanges();
        } 
    }
}