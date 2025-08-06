using CommandSystem;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using Exiled.Events.EventArgs.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FFonRoundEnd
{
    public class Main : Plugin<Config>
    {
        public override string Name => "AutoFFRE";

        public override string Prefix => "AutoFFRE";

        public override string Author => "Assasinowy G";

        public override PluginPriority Priority => PluginPriority.High;
        public override Version RequiredExiledVersion => this.RequiredExiledVersion;

        public override void OnDisabled()
        {
            throw new NotImplementedException();
        }

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Server.EndingRound += OnEndingRound;
        }
        public void OnEndingRound(EndingRoundEventArgs ev)
        {
            Server.FriendlyFire = true;
        }

        public override void OnReloaded()
        {
            throw new NotImplementedException();
        }
    }
}
