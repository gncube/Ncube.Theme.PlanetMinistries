# ADR-0002 — Oqtane Bootstrap 5 as Authoritative Styling Primitive

## Status
Accepted

## Context
Unify v2.6 shipped with Bootstrap 4 and extensive global style resets (`body`, `html`, `*`, `a`, `.btn`), which polluted Oqtane Control Panel, Administration dialogs, and module chrome.

## Decision
Oqtane's native Bootstrap 5 implementation is declared authoritative for the entire application. All Planet Ministries styling is strictly scoped under the `.pm-theme` CSS root boundary. Global CSS selectors outside `.pm-theme` are prohibited.

## Alternatives Considered
1. Loading an isolated iframe for the Control Panel (Rejected: Incompatible with Oqtane component lifecycle).
2. Overriding Oqtane Control Panel styles with escalating `!important` CSS rules (Rejected: Fragile specificity wars).

## Consequences
- Positive: Oqtane administrative UI remains visually untouched and standard across upgrades.
- Negative: Public theme styling must always prefix descendant rules with `.pm-theme`.

## Security Considerations
Preserves standard browser sandboxing and eliminates styling injections across tenant boundaries.

## Accessibility Considerations
Maintains standard Bootstrap 5 high-contrast accessibility tokens and native focus indicators across admin and public views.

## Operational Considerations
Theme updates cannot break core CMS administrative controls or module action buttons.