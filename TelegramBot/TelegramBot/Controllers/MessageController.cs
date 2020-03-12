using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;
using TelegramBot.Models;

namespace TelegramBot.Controllers
{
    public class MessageController : ApiController
    {
        [Route(@"api/message/update")]//webhook uri part
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var commands = Bot.Commands; // we get a list of available commands
            var message = update.Message; //prepear message for bot client
            var client = await Bot.Get(); // for send reply

            foreach (var command in commands)
            {
                if (command.Contains(message.Text))
                {
                    command.Execute(message, client);
                    break;
                }
            }
            return Ok();
        }
    }
}
