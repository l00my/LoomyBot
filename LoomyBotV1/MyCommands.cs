using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace LoomyBotV1
{
    public class MyCommands
    {
        [Command("hi")]
        public async Task Hi(CommandContext ctx)
        {
            await ctx.RespondAsync($"👋 Hi, {ctx.User.Mention}!");
        }

        [Command("ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.RespondAsync("pong!");
        }

        [Command("play7days")]
        public async Task PlaySevenDays(CommandContext ctx)
        {
            await ctx.RespondAsync("Starting 7 Days server!");
            await ctx.RespondAsync("Server is up, please wait for the WNKRGaming 7 Days server to start. Loomybot is " +
                $"currently unsure of how to determine this for you, {ctx.User.Mention}, Loomybot is sorry ><");
        }
    }
}
