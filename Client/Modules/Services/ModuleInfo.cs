using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Module.Corporate.Services
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Corporate Theme - Services",
            Description = "Add a Services section to your Corporate Theme",
            Version = "6.1.2",
            PackageName = "Ncube.Theme.PlanetMinistries"
        };
    }
}
