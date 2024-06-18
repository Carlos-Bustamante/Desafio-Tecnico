using Desafio_Tecnico.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tecnico.Repositories.Interfaces
{
    public interface IStockRepository: IRepository<Stock>
    {
        public Task<IEnumerable<Stock>> SearchAsync(string searchTerm);
    }
}
