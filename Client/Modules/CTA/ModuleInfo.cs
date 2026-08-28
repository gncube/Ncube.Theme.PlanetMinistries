using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Module.Corporate.CTA
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Corporate Theme - Call To Action",
            Description = "Add a Call To Action section to your Corporate Theme",
            Version = "6.1.2",
            PackageName = "Ncube.Theme.PlanetMinistries"
        };
    }
}
