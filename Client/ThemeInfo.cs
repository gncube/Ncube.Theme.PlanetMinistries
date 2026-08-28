using Oqtane.Shared;
using Oqtane.Themes;

namespace Ncube.Theme.PlanetMinistries;

public sealed class ThemeInfo : ITheme
{
    public Oqtane.Models.Theme Theme => new()
    {
        Name = "Planet Ministries Unify Classic Theme",
        Version = "2.0.0",
        ThemeName = typeof(ThemeInfo).Namespace,
        Resources =
        [
            new() { ResourceType = ResourceType.Stylesheet, Url = "assets/css/planet-ministries.css" },
            new() { ResourceType = ResourceType.Stylesheet, Url = "assets/css/unify/styles.bm-classic.sanitised.css" }
        ]
    };
}