using Microsoft.EntityFrameworkCore;
using GestaoDocumentos.Domain;

namespace GestaoDocumentos.Persistence
{
    public class GestaoDocumentoContext : DbContext
    {
        public GestaoDocumentoContext(DbContextOptions<GestaoDocumentoContext> options) : base(options) { }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<TipoDocumento> TiposDocumentos { get; set; }
        public DbSet<Concessao> Concessoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }  
    } 
}