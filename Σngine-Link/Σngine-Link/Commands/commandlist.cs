using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Σngine_Link.Commands    
{
    public class Corecommands : BaseCommandModule
    {
        [Command("History")]
        [Description("Displays the History of the Org")]
        //[RequireRoles(RoleCheckMode.Any, "Executive Vice Presidents")]

        public async Task History(CommandContext context)
        {
            await context.Channel.SendMessageAsync("Established in 2949, Founder and CEO, Tristan Ellis AKA TenthSigma set out to apply his passion for investing and business development into a full fledged operation. Having spent his entire career in business and finance, Sigma Ventures & Holdings was the product of not only entrepreneurship, but proven competency and expertise. Contributing to the growth of SVH has the major merger of SVH and Archon Enterprises that launched the group into the next level of success in ventures across the verse. SVH has made their mark on major projects and contracts quickly becoming known as one of the premier operations in UEE space dedicated to organizational collaboration, expansion, security and research in addition to its own business endeavors. At SVH, we firmly believe that the more opportunities we create for ourselves in our dealings around the universe, the more success we can find to fuel the dreams that we have both individually and collectively. We can only do that by accumulating and managing credits in the most efficient way possibleSimply put, we exist to do one thing: Maximize Opportunities and Maximize Credits for all of our members, stakeholders, partners and contractors. One stems from the other and that will always be our guiding principle. Whatever career you find yourself engaging in around the ‘verse, there’s a spot for you in Sigma Ventures & Holdings. You define success and together we achieve it").ConfigureAwait(false);
        }

        [Command("purge")]
        [Description("Deletes messages from the current channel")]
        [RequireRoles(RoleCheckMode.Any, "Executive Vice Presidents", "General Counsel")]

        public async Task<object> Purge(CommandContext context)
        {
            context.Channel.DeleteMessagesAsync
        }

       

    }
}

