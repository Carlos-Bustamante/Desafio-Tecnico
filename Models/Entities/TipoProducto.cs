using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tecnico.Models.Entities
{
    public class TipoProducto
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("DESCRIPCION", TypeName ="VARCHAR(200)")]
        public string Descripcion { get; set; }

        public ICollection<Producto> Producto { get; set; }

    }
}
