namespace Ncube.Theme.PlanetMinistries;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.JSInterop;

public sealed class Interop(IJSRuntime jsRuntime)
{
    public async ValueTask LoadAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            await jsRuntime.InvokeVoidAsync("Oqtane.Theme.load", cancellationToken);
        }
        catch (JSDisconnectedException)
        {
            // Circuit disconnected gracefully during teardown; no action required.
        }
        catch (JSException)
        {
            // Propagate or handle JavaScript execution errors specifically
            // rather than swallowing all unhandled application/runtime exceptions.
            throw;
        }
    }
}