using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Module.Corporate.Team
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Corporate Theme - Team",
            Description = "Add a Team section to your Corporate Theme",
            Version = "6.1.2",
            PackageName = "Ncube.Theme.PlanetMinistries"
        };
    }
}
