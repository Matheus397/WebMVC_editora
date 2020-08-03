using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaAplicacao.Models;
using MinhaAplicacao.Services;


namespace MinhaAplicacao.Controllers
{
    public class EditoraController : Controller
    {
        private readonly IEditoraService _service;

        public EditoraController(IEditoraService service) => _service = service;
        
        [HttpGet]
        public async Task<ActionResult<Editora>> BuscarEditora(int id) => View(await _service.EditoraById(id));
        [HttpPost]
        public async Task<IActionResult> CadastrarEditora(Editora editora)
        { 
            await _service.CreateEditora(editora);
            return RedirectToAction(nameof(ListarEditoras));
        }
        public async Task<IActionResult> ListarEditoras() => View(await _service.ListAsync());
        public IActionResult CadastrarEditora() => View();
    }
}
