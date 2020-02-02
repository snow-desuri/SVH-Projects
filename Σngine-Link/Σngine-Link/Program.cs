using System;
using Discord;
using Discord.Net;
using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Σngine_Link
{
    class Program
    {
        static void Main(string[] args)
           
        {
            var bot = new Bot();
            bot.RunAsync().GetAwaiter().GetResult();
           
        }     
         
    }
}
