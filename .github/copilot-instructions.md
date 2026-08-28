# Ncube.Theme.PlanetMinistries — Copilot Instructions

## Core Principle
Oqtane Bootstrap 5 is the **sole Bootstrap implementation**.
Unify v2.6 is a **visual design source**, not the application framework.

## CSS Ownership Model
### Oqtane-Owned (Do NOT override)
- Bootstrap 5 framework
- Control Panel UI
- Administration UI
- Module chrome
- System forms/dialogs

### Planet Ministries-Owned (Safe to customize)
- Public header/navigation
- Branding/colors
- Blog layouts
- Public footer
- Theme-specific components

## Dangerous Selectors — MODIFICATION RULES

### Global Elements (MUST scope under .pm-theme)
❌ DO NOT write global `body {}`, `a {}`, `h1 {}` rules
✅ DO write `.pm-theme { ... }`, `.pm-theme a { ... }`, etc.

#### Before/After Reference

**BEFORE (Dangerous):**
```css
body {
    font-family: "Open Sans", Helvetica, Arial, sans-serif;
    color: #2c2f37;
}

a {
    color: #6281c8;
}

a:hover {
    color: #4f72c1;
}
```

**AFTER (Safe):**
.pm-theme {
    font-family: "Open Sans", Helvetica, Arial, sans-serif;
    color: #2c2f37;
}

.pm-theme a {
    color: #6281c8;
    outline: none;
}

.pm-theme a:hover,
.pm-theme a:focus {
    color: #4f72c1;
}


