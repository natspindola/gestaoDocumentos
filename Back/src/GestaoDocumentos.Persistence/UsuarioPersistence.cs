using System.Threading.Tasks;
using GestaoDocumentos.Domain;
using GestaoDocumentos.Persistence.Contextos;
using GestaoDocumentos.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;

namespace GestaoDocumentos.Persistence
{
    public class UsuarioPersistence : IUsuarioPersistence
    {
        private readonly GestaoDocumentoContext _context;

        public UsuarioPersistence(GestaoDocumentoContext context)
        {
            _context = context;
        }

        public async Task<Usuario> GetUsuarioByIdAsync(string matricula, string senha)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(a => a.Matricula == matricula && a.Senha == senha);
        }
    }
}