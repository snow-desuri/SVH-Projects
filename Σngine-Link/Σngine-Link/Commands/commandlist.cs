using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.EventArgs;
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
            await context.Channel.SendMessageAsync("```Established in 2949, Founder and CEO, Tristan Ellis AKA TenthSigma set out to apply his passion for investing and business development into a full fledged operation. Having spent his entire career in business and finance, Sigma Ventures & Holdings was the product of not only entrepreneurship, but proven competency and expertise. Contributing to the growth of SVH has the major merger of SVH and Archon Enterprises that launched the group into the next level of success in ventures across the verse. SVH has made their mark on major projects and contracts quickly becoming known as one of the premier operations in UEE space dedicated to organizational collaboration, expansion, security and research in addition to its own business endeavors. At SVH, we firmly believe that the more opportunities we create for ourselves in our dealings around the universe, the more success we can find to fuel the dreams that we have both individually and collectively. We can only do that by accumulating and managing credits in the most efficient way possibleSimply put, we exist to do one thing: Maximize Opportunities and Maximize Credits for all of our members, stakeholders, partners and contractors. One stems from the other and that will always be our guiding principle. Whatever career you find yourself engaging in around the ‘verse, there’s a spot for you in Sigma Ventures & Holdings. You define success and together we achieve it```").ConfigureAwait(false);
        }

       [Command("Executive")]
       [Description("Shows what the Executive branch is.")]

       public async Task Executive(CommandContext context)
        {
            await context.Channel.SendMessageAsync("```Handles Negotiations, business deals and is overall the forward face of the organization. This group ideally will deal in VIP Transport and any activity that comes into the game that would require a delicate touch. It’s fleet size is not expected to be large, mostly consisting of ships from the Origin line, 300i all the way to Genesis Starliner. The leaders of this division will be able to handle contract deals and issue them to the appropriate sub-division.```").ConfigureAwait(false);
        }

        [Command("Support")]
        [Description("Shows what the Support branch is.")]

        public async Task Support(CommandContext context)
        {
            await context.Channel.SendMessageAsync("```This division is for those that would seek to lend a, “helping hand” to assist the org in its operations and ventures. Consisting of Doctors, engineers and other support specialists, this group takes care of all refueling, repairing and medial situations for the org.").ConfigureAwait(false);
        }

        [Command("Industrial")]
        [Description("Shows what the Industrial branch is.")]

        public async Task Industrial(CommandContext context)
        {
            await context.Channel.SendMessageAsync("```The industrial fleet is the backbone of the Organization. This fleet is ideal for those who want to mine and salvage ships. This is the ideal division for those who want to be a part of larger crews for salvage operations and mining. Supported by the Transport and Military divisions, this is also for those who wish to avoid combat when possible.```").ConfigureAwait(false);
        }

        [Command("Transport")]
        [Description("Shows what the Transport branch is.")]

        public async Task Transport(CommandContext context)
        {
            await context.Channel.SendMessageAsync("```This division is responsible for all transporting activities the Org engages in including but not limited to: small to large op cargo hauling, passenger transportation, and ship rescue operations (i.e. Space AAA). This will include all cargo ships and Repair facilities. ").ConfigureAwait(false);
        }

        [Command("Research")]
        [Description("Shows what the Research branch is.")]

        public async Task Research(CommandContext context)
        {
            await context.Channel.SendMessageAsync("```This division is the group that seeks to chart uncharted territories and make scientific advancements for the purpose of expanding the galactic footprint of Sigma Ventures & Holdings. This elite group of adventurers, scientists and explorers are skilled in their craft. They exist for the sole purpose of securing resources that other divisions can use in their operations and relaying any pertinent intel.```").ConfigureAwait(false);
        }

    }
}