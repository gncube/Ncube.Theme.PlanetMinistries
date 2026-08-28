namespace Ncube.Theme.PlanetMinistries.Containers;

using Ncube.Theme.PlanetMinistries.Client;
using Oqtane.Models;
using Oqtane.Themes;

public sealed class ContainerInfo : ITheme
{
    public Theme Theme => new()
    {
        Name = "Planet Ministries Containers",
        Version = ThemeVersion.Current,
        ThemeName = typeof(ContainerInfo).Namespace
    };
}