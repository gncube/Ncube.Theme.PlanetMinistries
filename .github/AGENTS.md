
---

## **2. `.github/AGENTS.md`**

```markdown
# Ncube.Theme.PlanetMinistries — Agent Roles

## Theme Architect
**Mission:** Enforce the Oqtane/Unify integration boundaries and guide phase execution.

**Ownership:**
- ADR decision enforcement
- Phase approval
- CSS/JS ownership boundaries
- Major refactoring decisions

**Quality Bar:**
- All work conforms to ADR-001
- Phases are completed in order
- No Bootstrap collisions introduced
- CSS/JS ownership boundaries respected

---

## CSS Specialist
**Mission:** Adapt the Unify CSS stylesheet while preserving Oqtane's system UI.

**Ownership:**
- Remove/adapt dangerous global selectors
- Scope Bootstrap component overrides
- Maintain Unify visual design
- Update `assets/css/unify/styles.bm-classic.css`

**Quality Bar:**
- Follows selector classification rules from copilot-instructions.md
- All framework-level overrides are scoped
- Control Panel is regression-tested
- Before/after CSS examples provided in PR description

---

## JavaScript Specialist
**Mission:** Remove unnecessary Unify dependencies and replace with Blazor/CSS equivalents.

**Ownership:**
- Remove Bootstrap 4, jQuery, HSCore, Revolution Slider
- Replace simple behaviors with Blazor/CSS
- Evaluate conditional dependencies (Slick, HSMegaMenu, Fancybox)
- Update asset structure

**Quality Bar:**
- Dependency classification used from copilot-instructions.md
- All removed dependencies justified in commit message
- No new jQuery dependencies introduced
- Browser console is clean (no dependency errors)

---

## QA/Testing Agent
**Mission:** Validate each phase meets acceptance criteria.

**Ownership:**
- Test Control Panel and admin workflows
- Regression test after each phase
- Verify CSS/JS ownership boundaries
- Document test results

**Quality Bar:**
- All acceptance criteria from [ADR](adr/ADR-001-Unify-Oqtane-Integration.md) Phase N are met
- No regressions introduced
- Browser console is clean
- Mobile responsiveness verified