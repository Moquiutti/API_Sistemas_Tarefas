namespace SistemaDeTarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? nome { get; set; }
        public string? descrição { get; set; }
        public int status { get; set; }
    }
}
