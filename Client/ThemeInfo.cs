using System.Collections.Generic;
using Oqtane.Models;
using Oqtane.Shared;
using Oqtane.Themes;

namespace Ncube.Theme.PlanetMinistries;

public sealed class ThemeInfo : ITheme
{
    public Oqtane.Models.Theme Theme => new()
    {
        Name = "Planet Ministries Unify Classic Theme",
        Version = "1.0.0",
        ThemeName = typeof(ThemeInfo).Namespace,
        Resources =
        [
            new Resource
            {
                ResourceType = ResourceType.Stylesheet,
                Url = "https://fonts.googleapis.com/css2?family=Open+Sans:wght@300;400;600;700&family=Roboto+Slab:wght@400;700&display=swap"
            },
            new Resource
            {
                ResourceType = ResourceType.Stylesheet,
                Url = $"{ThemeConstants.AssetBasePath}/vendor/font-awesome/css/font-awesome.min.css"
            },
            new Resource
            {
                ResourceType = ResourceType.Stylesheet,
                Url = $"{ThemeConstants.AssetBasePath}/vendor/simple-line-icons/css/simple-line-icons.min.css"
            },
            new Resource
            {
                ResourceType = ResourceType.Stylesheet,
                Url = $"{ThemeConstants.AssetBasePath}/css/brand-theme.css"
            }
        ]
    };
}