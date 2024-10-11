using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace _20240813v.DTOs
{
    public class UpdateProductDto
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [Required]
        public double Precio { get; set; }
        [Required]
        public string Categoria { get; set; }
        [Required]
        public int CantidadEnStock { get; set; }
        
    }
}
