using System.ComponentModel.DataAnnotations;

namespace Agenda_project.Entities
{
    public class ToDos
    {
        [Key]
        public int ToDoId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public long ChatId { get; set; }
    }
}
