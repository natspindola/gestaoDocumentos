using System;

namespace GestaoDocumentos.Domain
{
    public class Documento
    {
        public int Id { get; set; }
        public Concessao Concessao { get; set; }
        public string documento {get; set;}
        public DateTime dataAtualizacao { get; set; }
        public Usuario Elaborador { get; set; }
        public string grupoAcesso { get; set; }
        public string Status {get; set; }
        public string Acesso { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
    }
}