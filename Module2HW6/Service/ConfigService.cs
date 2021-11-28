using System.IO;
using Module2HW6.Config;
using Module2HW6.Service.Abstractions;
using Newtonsoft.Json;

namespace Module2HW6.Service
{
    public class ConfigService : IConfigService
    {
        private Configure _configure;
        public ConfigService()
        {
            var text = File.ReadAllText("config.json");
            _configure = JsonConvert.DeserializeObject<Configure>(text);
        }

        public Configure GetConfig()
        {
            return _configure;
        }
    }
}
