using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tecnico.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public Task<IEnumerable<TEntity>> GetAll();
        TEntity Get(int id);
        public Task<bool> Add(TEntity data);

        public Task<bool> Delete(int id);

        public Task<bool> Update(TEntity data);

        void Save();

    }
}
