namespace Ncube.Theme.PlanetMinistries.Client;

using System.Reflection;

public static class ThemeVersion
{
    private static readonly string CachedVersion =
        typeof(ThemeVersion).Assembly
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
            .InformationalVersion
            .Split('+')[0]
        ?? typeof(ThemeVersion).Assembly.GetName().Version?.ToString(3)
        ?? "2.0.1";

    public static string Current => CachedVersion;
}