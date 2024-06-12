using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tecnico.Models.Entities
{
    public class Producto
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        public int IdTipoProducto { get; set; }

        [Column("NOMBRE", TypeName = "VARCHAR(50)")]
        public string Nombre { get; set; }

        [Column("PRECIO")]
        public float Precio { get; set; }

        [ForeignKey("IdTipoProducto")]
        public ICollection<TipoProducto> TipoProductos { get; set; }

        public virtual Stock Stock { get; set; }
    }
}
