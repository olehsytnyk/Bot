using Telegram.Bot.Types;
using Telegram.Bot;

namespace TelegramBot.Models.Command
{
    public abstract class Command
    {
        public abstract string Name { get; }

        public abstract void Execute(Message message, TelegramBotClient client);

        public bool Contains(string comand)
        {
            return comand.Contains(this.Name) && comand.Contains(AppSettings.Name);
        }
    }
}