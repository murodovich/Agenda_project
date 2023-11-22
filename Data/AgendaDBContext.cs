using Agenda_project.Entities;
using Microsoft.EntityFrameworkCore;

namespace Agenda_project.Data
{
    public class AgendaDBContext : DbContext
    {
        public AgendaDBContext(DbContextOptions<AgendaDBContext> options) : base(options) 
        { 
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ToDos> ToDos { get; set; }

        

    }
}
