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
        Version = "2.0.0",
        ThemeName = typeof(ThemeInfo).Namespace,
        Resources =
        [
            new Resource
            {
                ResourceType = ResourceType.Stylesheet,
                Url = "https://fonts.googleapis.com/css?family=Roboto+Slab:300,400,700%7COpen+Sans:400,600,700"
            },
            new Resource
            {
                ResourceType = ResourceType.Stylesheet,
                Url = $"{ThemeConstants.AssetBasePath}/vendor/icon-awesome/css/font-awesome.min.css"
            },
            new Resource
            {
                ResourceType = ResourceType.Stylesheet,
                Url = $"{ThemeConstants.AssetBasePath}/vendor/icon-line/css/simple-line-icons.css"
            },
            new Resource
            {
                ResourceType = ResourceType.Stylesheet,
                Url = $"{ThemeConstants.AssetBasePath}/vendor/animate.css"
            },
            new Resource
            {
                ResourceType = ResourceType.Stylesheet,
                Url = $"{ThemeConstants.AssetBasePath}/css/brand-theme.css"
            }
        ]
    };
}