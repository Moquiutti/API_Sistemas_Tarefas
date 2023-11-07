using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositórios.Interfaces;

namespace SistemaDeTarefas.Repositórios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public readonly SistemaTarefasDBContext _dbContext;
        
        public UsuarioRepositorio(SistemaTarefasDBContext sistemaTarefasDBContext) 
        {
            _dbContext = sistemaTarefasDBContext;
        }

        public async Task<UsuárioModel> BuscarPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.id == id);
        }

        public Task<List<UsuárioModel>> BuscarTodosUsuarios()
        {
            return _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuárioModel> Adicionar(UsuárioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            _dbContext.SaveChanges();
            return usuario;
        }

        public async Task<UsuárioModel> Atualizar(UsuárioModel usuario, int id)
        {
            UsuárioModel usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null) 
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }

            usuarioPorId.nome = usuario.nome;
            usuarioPorId.email = usuario.email;

            _dbContext.Usuarios.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();
            return usuarioPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuárioModel usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

       
    }
}
