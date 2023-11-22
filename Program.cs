using Agenda_project.BackgroundServices;
using Agenda_project.Data;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AgendaDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var token = builder.Configuration["token"];
builder.Services.AddSingleton(new TelegramBotClient(token));
builder.Services.AddHostedService<BotBackgraundService>();

var app = builder.Build();



app.Run();
