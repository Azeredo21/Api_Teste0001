using System.ComponentModel.DataAnnotations;

namespace Api_Teste0001.ViewModels
{
    public class CreateTodoViewModel{
        [Required]
        public string Title { get; set; }
    }
}