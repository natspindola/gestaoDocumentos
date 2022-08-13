using System.Collections.Generic;
using GestaoDocumentos.Persistence;
using GestaoDocumentos.Domain;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDocumentos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentoController : ControllerBase
    {
        private readonly GestaoDocumentoContext _context;
        public DocumentoController(GestaoDocumentoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Documento> Get()
        {
            return _context.Documentos;
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }

        [HttpPut]
        public string Put()
        {
            return "Exemplo de put";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete com id = {id}";
        }
    }
}