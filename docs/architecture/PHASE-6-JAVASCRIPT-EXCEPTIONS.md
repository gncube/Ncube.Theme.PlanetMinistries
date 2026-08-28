# Phase 6 — JavaScript Exceptions & Interop Registry

| Feature | Why JS is Required | Why Blazor/HTML/CSS Is Insufficient | Dependency | Lifecycle | Owner |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **Oqtane Core Interop** | Invoking `Oqtane.Theme.load` runtime lifecycle | Required by Oqtane framework architecture to hydrate module containers | `Interop.cs` (Native Blazor JSInterop) | OnAfterRenderAsync | Theme Root |
| **Custom JS** | *NONE* | Blazor component state, CSS3 transitions, and Bootstrap 5 native data attributes satisfy all public UI requirements | None | N/A | None |