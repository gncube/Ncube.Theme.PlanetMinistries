using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Module.Corporate.Clients
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Corporate Theme - Clients",
            Description = "Add a Clients section to your Corporate Theme",
            Version = "6.1.2",
            PackageName = "Ncube.Theme.PlanetMinistries"
        };
    }
}
