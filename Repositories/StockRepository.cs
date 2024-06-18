using Desafio_Tecnico.Models;
using Desafio_Tecnico.Models.Entities;
using Desafio_Tecnico.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tecnico.Repositories
{
    public class StockRepository: Repository<Stock>, IStockRepository
    {

        public StockRepository(TestContext testContext): base(testContext){
            
        }

        public async Task<IEnumerable<Stock>> SearchAsync(string searchTerm)
        {
            return await _context.Stocks
                .Include(s => s.Producto)
                .Where(s => s.Producto.Nombre.Contains(searchTerm))
                .ToListAsync();
        }
    }
}
