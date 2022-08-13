using System.Linq;
using System.Threading.Tasks;
using GestaoDocumentos.Domain;
using GestaoDocumentos.Persistence.Contextos;
using GestaoDocumentos.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;

namespace GestaoDocumentos.Persistence
{
    public class DocumentoPersistence : IDocumentoPersistence
    {
        private readonly GestaoDocumentoContext _context;

        public DocumentoPersistence(GestaoDocumentoContext context)
        {
            _context = context;
        }

        public async Task<Documento> GetDocumentoByIdAsync(int documentoId)
        {
            return await _context.Documentos.FirstOrDefaultAsync(a => a.Id == documentoId);
        }

        public async Task<Documento[]> GetAllDocumentosAsync()
        {
            IQueryable<Documento> query = _context.Documentos;
            
            query = query.OrderBy(d => d.Id);
            return await query.ToArrayAsync();
        }
    }
}