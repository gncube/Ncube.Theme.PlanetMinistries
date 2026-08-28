using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Module.Corporate.FAQ
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Corporate Theme - FAQs",
            Description = "Add an FAQs section to your Corporate Theme",
            Version = "6.1.2",
            PackageName = "Ncube.Theme.PlanetMinistries"
        };
    }
}
