using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tecnico.Models.Entities
{
    internal class TipoProducto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("DESCRIPCION")]
        public int Descripcion { get; set; }

    }
}
