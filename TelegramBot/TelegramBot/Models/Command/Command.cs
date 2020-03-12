using Telegram.Bot.Types;
using Telegram.Bot;

namespace TelegramBot.Models.Commands
{
    public abstract class Command
    {
        public abstract string Name { get; }

        public abstract void Execute(Message message, TelegramBotClient client);

        public bool Contains(string command)
        {
            //will check the command and bot name so as not to be confused with another
            return command.Contains(this.Name) && command.Contains(AppSettings.Name);
        }
    }
}