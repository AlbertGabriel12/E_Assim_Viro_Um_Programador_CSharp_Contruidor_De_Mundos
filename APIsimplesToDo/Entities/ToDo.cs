namespace APIsimplesToDo;

public class ToDo
{

    public ToDo(string nome)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Checked = false;
    }

    public Guid Id { get; }
    public string Nome { get; set; }
    public bool Checked { get; set; }
}