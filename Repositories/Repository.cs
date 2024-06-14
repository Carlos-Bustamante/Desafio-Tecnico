using Desafio_Tecnico.Models;
using Desafio_Tecnico.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tecnico.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly TestContext _context;
        private DbSet<TEntity> _dbSet;
        public Repository(TestContext testContext)
        {
            _context = testContext;
        }

        public virtual async Task<bool> Add(TEntity data)
        {
            await _dbSet.AddAsync(data);
            return true;
        }
        public async Task<bool> Delete(int id)
        {
            var dataToDelete = await _dbSet.FindAsync(id);

            // Valida si lo encuentra
            if (dataToDelete == null) { return false; }

            _dbSet.Remove(dataToDelete!);
            return true;
        }
        public TEntity? Get(int id) => _dbSet.Find(id);
        public async Task<IEnumerable<TEntity>> GetAll() => await _dbSet.ToListAsync();
        public void Save() => _context.SaveChanges();
        public virtual async Task<bool> Update(TEntity data)
        {
            _dbSet.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
            return true;
        }

    }
}
