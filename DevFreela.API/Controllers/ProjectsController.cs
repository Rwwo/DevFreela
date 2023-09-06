using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Any;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly OpeningTimeOptions _opt;
        public ProjectsController(IOptions<OpeningTimeOptions> opt)
        {
            this._opt = opt.Value;
        }
        //Buscar
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        //Filtrar 1
        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
            //return NotFound();

            return Ok();
        }

        //Cadastrar
        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            return CreatedAtAction(nameof(GetbyId), new { Id = createProject.Id }, createProject);
        }


        //Atualizar
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //CASO NÃO EXISTA;

            //remover

            return NoContent();

        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }


    }
}
