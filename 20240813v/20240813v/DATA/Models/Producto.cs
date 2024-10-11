using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace _20240813v.DATA.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }


        public string Nombre { get; set; }


        public string Descripcion { get; set; }


        public double Precio { get; set; }
        
        public string Categoria { get; set; }

        public int CantidadEnStock { get; set; }
    }
}
