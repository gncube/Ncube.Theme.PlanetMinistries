using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Module.Corporate.WhyUs
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Corporate Theme - Why Us",
            Description = "Add a Why Us section to your Corporate Theme",
            Version = "6.1.2",
            PackageName = "Ncube.Theme.PlanetMinistries"
        };
    }
}
