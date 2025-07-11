using EsercizioEnviroment.Options;
using Microsoft.Extensions.Options;

namespace EsercizioEnviroment.Services
{
    public class GreetingService : IGreetingService
    {
        private readonly GreetingsOptions _options;
        private readonly IWebHostEnvironment _env;

        public GreetingService(IOptions<GreetingsOptions> options, IWebHostEnvironment env)
        {
            _options = options.Value;
            _env = env;
        }

        public string GetGreeting()
        {
            if(!_options.EnableGreeting)
            {
                return string.Empty;
            }
            var envName = _env.EnvironmentName;
            return $"[{envName}] {_options.Message}";
        }
    }
}
