using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Todo_AspNet_MVC_.Models
{
    public class Todo
    {
        public int ID { get; set; }

        [DisplayName("Titulo")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Title { get; set; }

        [DisplayName("Concluido")]
        public bool Done { get; set; }

        [DisplayName("Criado em")]
        public DateTime CreateAt { get; set; } = DateTime.Now;
        
        [DisplayName("Ultima Atualizacao")]
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;

        [DisplayName("Usuario")]
        public string User { get; set; }

    }
}
