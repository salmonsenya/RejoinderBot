using Microsoft.Extensions.Options;
using System;

namespace RejoinderBot
{
    public class ConfigurationHelper : IConfigurationHelper
    {
        private readonly string _token;
        private readonly BotConfiguration _botConfiguration;

        public ConfigurationHelper(IOptions<BotConfiguration> botConfiguration)
        {
            _botConfiguration = botConfiguration?.Value ?? throw new ArgumentNullException(nameof(botConfiguration));
            _token = _botConfiguration?.BotToken;
        }

        public string getToken() => _token;
    }
}
