using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.interfaces;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository: ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> categorias => _context.Categorias;
    }
}