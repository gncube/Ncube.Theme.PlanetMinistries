using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Module.Corporate.Pricing
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Corporate Theme - Pricing",
            Description = "Add a Pricing section to your Corporate Theme",
            Version = "6.1.2",
            PackageName = "Ncube.Theme.PlanetMinistries"
        };
    }
}
