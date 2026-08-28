# ADR-0001 — C#-First and Minimal JavaScript Theme Architecture

## Status
Accepted

## Context
The legacy Unify v2.6 theme depended on over 500KB of obsolete JavaScript libraries (jQuery, jQuery Migrate, Popper v1, Slick Carousel, Fancybox, CountTo, HS Plugins). This caused script collisions with Oqtane Blazor rendering lifecycles, memory leaks, and supply chain maintenance liabilities.

## Decision
The Planet Ministries theme enforces a C#-first architecture. All interactive UI state (mobile menu drawers, dropdowns, accordions, tabs, lightboxes, and animated counters) is implemented natively in Blazor and CSS3 transitions. Zero custom JavaScript modules are loaded; JS interop is restricted to the native Oqtane runtime lifecycle hook (`Oqtane.Theme.load`).

## Alternatives Considered
1. Upgrading jQuery and Unify plugins to modern JavaScript equivalents (Rejected: Perpetuates dual-framework runtime complexity).
2. Adopting third-party Blazor UI component libraries like MudBlazor or Radzen (Rejected: Introduces heavy dependency overhead and conflicts with Oqtane's native Bootstrap 5 chrome).

## Consequences
- Positive: Main-thread execution time reduced; zero third-party JS security vulnerabilities; fully testable via bUnit without headless browser drivers.
- Negative: Reusable interactive patterns must be maintained directly within the theme project.

## Security Considerations
Eliminates `eval()`, `document.write()`, and untrusted DOM string injections inherited from legacy templates.

## Accessibility Considerations
Enables complete server/client control over ARIA attributes (`aria-expanded`, `aria-controls`, `aria-live`) and native keyboard event handling.

## Operational Considerations
No client-side npm/bundling toolchain required during CI/CD build; builds rely entirely on standard `dotnet build` and `dotnet publish`.