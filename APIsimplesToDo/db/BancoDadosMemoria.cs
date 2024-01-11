namespace APIsimplesToDo;

public class BancoDadosMemoria
{
    public List<ToDo> listaDeToDos { get; set; }

    public BancoDadosMemoria()
    {
        listaDeToDos = new List<ToDo>();
    }


    public List<ToDo> TrazerTodosOsToDo()
    {
        return listaDeToDos;
    }

    public void AdicionarToDo(ToDo toDo)
    {
        listaDeToDos.Add(toDo);
    }

    public bool AtualizarToDo(Guid Id, string Nome, bool Checked)
    {
        var result = listaDeToDos.Find(cadaToDo => cadaToDo.Id == Id);

        if (result != null)
        {
            result.Nome = Nome;
            result.Checked = Checked;

            return true;
        }
        else
        {
            return false;
        }
    }

    public bool DeletarToDo(Guid Id)
    {
        var result = listaDeToDos.RemoveAll(cadaToDo => cadaToDo.Id == Id);

        if (result != 0) return true;
        else return false;
    }
}