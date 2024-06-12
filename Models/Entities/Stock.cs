using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tecnico.Models.Entities
{
    public class Stock
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        public int IdProducto { get; set; }

        [Column("CANTIDAD")]
        public int Cantidad { get; set; }

        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }

    }
}
