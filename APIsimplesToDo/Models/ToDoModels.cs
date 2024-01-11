using System.ComponentModel.DataAnnotations;

namespace APIsimplesToDo;

public class ToDoModels(Guid Id, string Nome, bool Checked)
{
    public Guid Id { get; set; } = Id;

    [Required(ErrorMessage = "The name is required.")]
    public string Nome { get; set; } = Nome;

    public bool Checked { get; set; } = Checked;
}