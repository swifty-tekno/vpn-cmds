using System.Collections.Concurrent;
using System.Reflection;
using System.Threading.Tasks;
using Plugins.Vpn.Commands;
using SharedLibraryCore;
using SharedLibraryCore.Commands;
using SharedLibraryCore.Database.Models;
using SharedLibraryCore.Exceptions;
using SharedLibraryCore.Interfaces;

namespace vpn_cmds
{
    public class Plugin : IPlugin
    {
        public string Name => "VPN cmds";

        public float Version => Assembly.GetExecutingAssembly().GetName().Version.Major + Assembly.GetExecutingAssembly().GetName().Version.Minor / 10.0f;

        public string Author => "Swifty";


        //lol idk what im doing
        public Task OnEventAsync(GameEvent E, Server S) => Task.CompletedTask;

        public Task OnLoadAsync(IManager manager) => Task.CompletedTask;

        public Task OnTickAsync(Server S) => Task.CompletedTask;

        public Task OnUnloadAsync() => Task.CompletedTask;
    }
}
