using Oqtane.Models;
using Oqtane.Themes;

namespace Ncube.Theme.PlanetMinistries.Containers;

public sealed class ContainerInfo : IContainer
{
    public Container Container => new()
    {
        Name = "Planet Ministries Containers",
        Version = "1.0.0",
        ContainerName = typeof(ContainerInfo).Namespace
    };
}