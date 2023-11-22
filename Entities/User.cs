using System.ComponentModel.DataAnnotations;

namespace Agenda_project.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public long ChatId { get; set; } 

    }
}
