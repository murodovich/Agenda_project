using Agenda_project.BackgroundServices;
using Telegram.Bot;

var builder = WebApplication.CreateBuilder(args);

var token = builder.Configuration["token"];
builder.Services.AddSingleton(new TelegramBotClient(token));
builder.Services.AddHostedService<BotBackgraundService>();

var app = builder.Build();



app.Run();
