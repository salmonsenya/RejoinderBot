using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace RejoinderBot
{
    public class UpdateService : IUpdateService
    {
        private readonly IConfigurationHelper _configurationHelper;
        private readonly TelegramBotClient client;

        public UpdateService(IConfigurationHelper configurationHelper)
        {
            _configurationHelper = configurationHelper ?? throw new ArgumentNullException(nameof(configurationHelper));
            client = new TelegramBotClient(_configurationHelper.getToken());
        }

        public async Task ReplyAsync(Update update)
        {
            if (update.Type != UpdateType.Message)
                return;

            var message = update.Message;
            if (message.Type == MessageType.Text)
            {
                var input = message.Text;
                if (input != null)
                {
                    var regexYes = new Regex(@"(^((да)|(Да)|(ДА))(\?*|\.*|!*)$)|(((\s|,)да\?+)$)");
                    if (regexYes.IsMatch(input))
                    {
                        await client.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            replyToMessageId: message.MessageId,
                            text: $"пизда");
                    }

                    var regexNo = new Regex(@"(^((нет)|(Нет)|(НЕТ))(\.*|!*)$)");
                    if (regexNo.IsMatch(input))
                    {
                        await client.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            replyToMessageId: message.MessageId,
                            text: $"пидора ответ");
                    }
                }
            }
        }
    }
}
