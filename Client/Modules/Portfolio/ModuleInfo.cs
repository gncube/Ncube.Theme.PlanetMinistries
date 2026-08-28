using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Module.Corporate.Portfolio
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Corporate Theme - Portfolio",
            Description = "Add a Portfolio section to your Corporate Theme",
            Version = "6.1.2",
            PackageName = "Ncube.Theme.PlanetMinistries"
        };
    }
}
