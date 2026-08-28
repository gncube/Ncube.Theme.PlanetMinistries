namespace Ncube.Theme.PlanetMinistries.Client;

using Oqtane.Models;
using Oqtane.Shared;
using Oqtane.Themes;

public sealed class ThemeInfo : ITheme
{
    public Theme Theme => new()
    {
        Name = "Planet Ministries Theme",
        Version = "2.0.1",
        ThemeName = typeof(ThemeInfo).Namespace,
        Resources =
        [
            new()
            {
                ResourceType = ResourceType.Stylesheet,
                Url = "_content/Ncube.Theme.PlanetMinistries.Client/assets/css/planet-ministries.css"
            },
            new()
            {
                ResourceType = ResourceType.Stylesheet,
                Url = "_content/Ncube.Theme.PlanetMinistries.Client/assets/css/unify/styles.bm-classic.sanitised.css"
            }
        ]
    };
}