using VSDev.MVC.Models;
using VSDev.MVC.Services.Interface;

namespace VSDev.MVC.Services
{
    public class ArtigoRepository : IArtigoRepository
    {
        public Artigo ArtigoEmBranco()
        {
            return new Artigo
            {
                IdArtigo = 1,
                Titulo = "Artigo para Testes"
            };
        }
    }
}
