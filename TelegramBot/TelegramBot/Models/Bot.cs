using System.Threading.Tasks;
using Telegram.Bot;


namespace TelegramBot.Models
{
    public class Bot
    {
        private static TelegramBotClient client;

        public async Task<TelegramBotClient> Get()
        {
            if (client != null)
            {
                return client;
            }

            client = new TelegramBotClient(AppSettings.Key);
            await client.SetWebhookAsync("");

            return client;
        }
    }
}