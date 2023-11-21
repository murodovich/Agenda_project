
using Agenda_project.Services;
using Telegram.Bot;

namespace Agenda_project.BackgroundServices
{
    public class BotBackgraundService : BackgroundService
    {
        private TelegramBotClient _client;

        public BotBackgraundService(TelegramBotClient client)
        {
            _client = client;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine("Salom");
            _client.StartReceiving<UpdateHandlerService>(null, stoppingToken);
            return Task.CompletedTask;
        }
    }
}
