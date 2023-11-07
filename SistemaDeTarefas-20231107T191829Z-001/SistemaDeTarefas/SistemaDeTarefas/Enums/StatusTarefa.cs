using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public class StatusTarefa
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("E andamento")]
        EmAndamento = 2,
        [Description("Concluido")]
        Concluido = 3
         
    }
}
