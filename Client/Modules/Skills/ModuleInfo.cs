using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Module.Corporate.Skills
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Corporate Theme - Skills",
            Description = "Add a Skills section to your Corporate Theme",
            Version = "6.1.2",
            PackageName = "Ncube.Theme.PlanetMinistries"
        };
    }
}
