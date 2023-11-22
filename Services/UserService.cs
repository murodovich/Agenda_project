using Agenda_project.Data;
using Agenda_project.Dtos;
using Agenda_project.Entities;
using Microsoft.EntityFrameworkCore;

namespace Agenda_project.Services
{
    public class UserService
    {
        private readonly AgendaDBContext _context;

        public UserService(AgendaDBContext context)
        {
            _context = context;
        }

        public  async ValueTask AddAsync(UserDto model)
        {
            var res = _context.Users.FirstOrDefaultAsync(x => x.ChatId == model.ChatId);
            if (res == null)
            {
                User user = new User();
                user.ChatId = model.ChatId;
                user.FirstName = model.FirstName;

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

            }
            
        }
    }
}
