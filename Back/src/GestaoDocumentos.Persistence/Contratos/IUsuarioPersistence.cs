using System.Threading.Tasks;
using GestaoDocumentos.Domain;

namespace GestaoDocumentos.Persistence.Contratos
{
    public interface IUsuarioPersistence
    {
        Task<Usuario> GetUsuarioByIdAsync(string matricula, string senha);
    }
}