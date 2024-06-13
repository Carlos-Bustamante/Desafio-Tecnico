using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tecnico.DTOs
{
    public class ProductoDTO
    {
        public ProductoDTO(int idTipoProducto, string nombre, float precio)
        {
            IdTipoProducto = idTipoProducto;
            Nombre = nombre;
            Precio = precio;
        }
 
        public int IdTipoProducto { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
    }
}
