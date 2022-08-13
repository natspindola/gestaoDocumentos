namespace GestaoDocumentos.Domain
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula {get; set;}
        public string Senha { get; set; }
        public bool Admin { get; set; }
    }
}