using SharedLibraryCore;
using SharedLibraryCore.Commands;
using SharedLibraryCore.Configuration;
using SharedLibraryCore.Database.Models;
using SharedLibraryCore.Interfaces;
using System.Threading.Tasks;

namespace Plugins.Vpn.Commands
{
    public class AllowVPN_Command : Command
    {
        public AllowVPN_Command(CommandConfiguration config, ITranslationLookup translationLookup) : base(config, translationLookup)
        {
            Name = "allowvpn";
            Description = "Add player @id to vpn exception list";
            Alias = "av";
            Permission = EFClient.Permission.Trusted;
            RequiresTarget = true;
            Arguments = new CommandArgument[]
            {
                new CommandArgument()
                {
                    Name = "@id or player name",
                    Required = true
                }
            };


        }

        public override Task ExecuteAsync(GameEvent E)
        {
            throw new System.NotImplementedException();
        }

    }

    public class RemoveVPN_Command : Command
    {
        public RemoveVPN_Command(CommandConfiguration config, ITranslationLookup translationLookup) : base(config, translationLookup)
        {
            Name = "removevpn";
            Description = "Remove player @id from vpn exception list";
            Alias = "rv";
            Permission = EFClient.Permission.Trusted;
            RequiresTarget = true;
            Arguments = new CommandArgument[]
            {
                new CommandArgument()
                {
                    Name = "@id or player name",
                    Required = true
                }
            };


        }

        public override Task ExecuteAsync(GameEvent E)
        {

            throw new System.NotImplementedException();
        }


    }
}