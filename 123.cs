
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;

namespace InfiniteRadioBattery
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "InfiniteRadioBattery";
        public override string Author => "radio";
        public override string Prefix => "IRB";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            base.OnEnabled();
            Exiled.Events.Handlers.Player.UsingRadioBattery += OnUsingRadioBattery;
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.UsingRadioBattery -= OnUsingRadioBattery;
            base.OnDisabled();
        }

        private void OnUsingRadioBattery(UsingRadioBatteryEventArgs ev)
        {
            ev.IsAllowed = false; // Prevent battery from depleting
        }
    }
}