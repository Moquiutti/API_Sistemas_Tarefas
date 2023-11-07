using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositórios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuárioModel>> BuscarTodosUsuarios();
        Task<UsuárioModel> BuscarPorId(int id);
        Task<UsuárioModel> Adicionar(UsuárioModel usuario);
        Task<UsuárioModel> Atualizar(UsuárioModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}
