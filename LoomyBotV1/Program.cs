using System;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using System.Threading.Tasks;

namespace LoomyBotV1
{
    class Program
    {
        static DiscordClient discord;
        static CommandsNextModule commands;

        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();   
        }

        static async Task MainAsync(string[] args)
        {
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "MzQ1NTI3MDQxMTExNjIxNjMz.DG8mAQ.O2rFq8upPaCY_cmehblZ212EdnQ",
                TokenType = TokenType.Bot,
                UseInternalLogHandler = true,
                LogLevel = LogLevel.Debug
            });

            commands = discord.UseCommandsNext(new CommandsNextConfiguration
            {
                StringPrefix = "!"
            });

            commands.RegisterCommands<MyCommands>();

            //discord.MessageCreated += async e =>
            //{
            //    if (e.Message.Content.ToLower().StartsWith("!ping"))
            //        await e.Message.RespondAsync("pong!");
            //};

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}