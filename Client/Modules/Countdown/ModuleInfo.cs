using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Module.Corporate.Countdown
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Corporate Theme - Countdown",
            Description = "Add a Countdown section to your Corporate Theme",
            Version = "6.1.2",
            PackageName = "Ncube.Theme.PlanetMinistries"
        };
    }
}
