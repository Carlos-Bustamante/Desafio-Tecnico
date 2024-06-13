using Desafio_Tecnico.DTOs;
using Desafio_Tecnico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tecnico.Repositories
{
    internal class ProductoRepository: Repository<ProductoDTO>
    {
        public ProductoRepository(TestContext testContext): base(testContext)
        {
            
        }

    }
}
