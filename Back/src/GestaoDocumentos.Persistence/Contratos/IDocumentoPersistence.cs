using System.Threading.Tasks;
using GestaoDocumentos.Domain;

namespace GestaoDocumentos.Persistence.Contratos
{
    public interface IDocumentoPersistence
    {
        Task<Documento[]> GetAllDocumentosAsync();
        Task<Documento> GetDocumentoByIdAsync(int DocumentoId);
    }
}