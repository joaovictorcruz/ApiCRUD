using System.Text.Json.Serialization;

namespace ApiCRUD.Models
{
    public class AutorModel
    {
         public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [JsonIgnore] // usando diretiva JsonIgnore para não aparecer a lista de livros,
                     // pois a propriedade ICollectio serve apenas para fazer a correlação entre LivroModel e AutorModel
        public ICollection<LivroModel> Livros { get; set; }

    }
}
