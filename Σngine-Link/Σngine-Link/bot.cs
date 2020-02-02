using System.IO;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using Newtonsoft.Json;
using Discord;
using Discord.Net;
using Discord.Commands;
using Σngine_Link.Commands;

namespace Σngine_Link
{
    public class Bot
    {
        public DiscordClient Client { get; private set; }
        public CommandsNextExtension Commands { get; private set; }


        public async Task RunAsync()

        {
            var json = string.Empty;

            using (var fs = File.OpenRead("config.json"))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                json = await sr.ReadToEndAsync().ConfigureAwait(false);

            var configjson = JsonConvert.DeserializeObject<configjson>(json);


            var config = new DiscordConfiguration
            {
                Token = configjson.Token,
                TokenType = DSharpPlus.TokenType.Bot,
                AutoReconnect = true,
                LogLevel = LogLevel.Debug,
                UseInternalLogHandler = true
            };

            Client = new DiscordClient(config);

            Client.Ready += OnClientReady;


            var commandsConfig = new CommandsNextConfiguration
            {
                StringPrefixes = new string[] { configjson.Prefix },
                EnableMentionPrefix = true,
                EnableDms = true
                

            };

            Commands = Client.UseCommandsNext(commandsConfig);

            Commands.RegisterCommands<Corecommands>();

            await Client.ConnectAsync();

            await Task.Delay(-1);
        }

        private Task OnClientReady(ReadyEventArgs e)
        {
            return Task.CompletedTask;
        }  
        
    }
}
