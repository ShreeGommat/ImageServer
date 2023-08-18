using Server.model;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Server
{
    //This class will be responsible to provide configuration management
    public class ConfigurationService
    {
        private static ConfigurationService _instance;
        private static SeverAppSettingsDbContext serverAppSettingsDbContext;
        private ConcurrentDictionary<string, string> configs = new ConcurrentDictionary<string, string>();

        public static ConfigurationService Instance(SeverAppSettingsDbContext context)
        {
            if(_instance == null )
            {
                _instance = new ConfigurationService();
                serverAppSettingsDbContext = context;
            }

            return _instance;
        }

        public void Initialize()
        {
            configs.Clear();
        }
    }
}
