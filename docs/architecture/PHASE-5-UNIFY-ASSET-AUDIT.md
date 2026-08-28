# Phase 5 — Unify Asset Audit & Classification

## 1. Vendor Script Inventory (All Removed)
* `assets/vendor/jquery/*` $\rightarrow$ **REMOVED** (Zero jQuery policy).
* `assets/vendor/jquery-migrate/*` $\rightarrow$ **REMOVED** (Legacy compatibility layer deleted).
* `assets/vendor/popper.js/*` $\rightarrow$ **REMOVED** (Oqtane provides Bootstrap 5 Popper runtime).
* `assets/vendor/bootstrap/*` (v4.x) $\rightarrow$ **REMOVED** (Oqtane Bootstrap 5 authoritative).
* `assets/vendor/slick-carousel/*` $\rightarrow$ **REMOVED** (Replaced by `PmCarousel.razor`).
* `assets/vendor/fancybox/*` $\rightarrow$ **REMOVED** (Replaced by `PmLightboxModal.razor`).
* `assets/vendor/appear.js`, `assets/vendor/hs-megamenu/*` $\rightarrow$ **REMOVED**.

## 2. Stylesheet Audit
* `assets/css/styles.bm-classic.css` $\rightarrow$ **SANITIZED** to `assets/css/unify/styles.bm-classic.sanitised.css`.
* `assets/css/planet-ministries.css` $\rightarrow$ **RETAINED** (Core design tokens and `.pm-theme` root scope).

## 3. Iconography & Fonts
* Icon library standardized on **Bootstrap Icons** (`bi bi-*`).
* All emoji icons strictly disallowed across templates and components.