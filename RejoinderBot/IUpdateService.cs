using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace RejoinderBot
{
    public interface IUpdateService
    {
        public Task ReplyAsync(Update update);
    }
}
