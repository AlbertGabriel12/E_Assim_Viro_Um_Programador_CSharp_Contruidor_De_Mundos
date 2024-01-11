using Microsoft.AspNetCore.Mvc;

namespace APIsimplesToDo.Controllers;

[Route("api/toDo")]
[ApiController]
public class ToDoController : ControllerBase
{

    private readonly BancoDadosMemoria _bancoDadosMemoria;

    public ToDoController(BancoDadosMemoria bancoDadosMemoria)
    {
        _bancoDadosMemoria = bancoDadosMemoria;
    }

    [HttpGet]
    public IActionResult GetAllToDos()
    {
        return Ok(_bancoDadosMemoria.TrazerTodosOsToDo());
    }

    [HttpPost]
    public IActionResult CriarNovoToDo(ToDo toDo)
    {
        _bancoDadosMemoria.AdicionarToDo(toDo);
        return CreatedAtAction(nameof(GetAllToDos), toDo);
    }

    [HttpPut("{Id}")]
    public IActionResult AtualizarToDo(Guid Id, string Nome, bool Checked)
    {
        return _bancoDadosMemoria.AtualizarToDo(Id, Nome, Checked) == true ? Ok() : NotFound("ToDo não encontrado");
    }

    [HttpDelete("{Id}")]
    public IActionResult DeletarToDo(Guid Id)
    {
        return _bancoDadosMemoria.DeletarToDo(Id) == true ? Ok() : NotFound();
    }
}