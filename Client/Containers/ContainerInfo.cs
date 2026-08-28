using Oqtane.Models;
using Oqtane.Themes;

namespace Ncube.Theme.PlanetMinistries.Containers;

public sealed class ContainerInfo : ITheme
{
    public Oqtane.Models.Theme Theme => new()
    {
        Name = "Planet Ministries Containers",
        Version = "1.0.0",
        ThemeName = typeof(ContainerInfo).Namespace
    };
}