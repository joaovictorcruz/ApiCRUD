using ApiCRUD.Models;

namespace ApiCRUD.Services.Autor
{
    public class AutorService : IAutorInterface
    {
        public Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AutorModel>> BuscarAutorPorLivro(int idLivro)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<AutorModel>>> ListarAutores()
        {
            throw new NotImplementedException();
        }
    }
}
