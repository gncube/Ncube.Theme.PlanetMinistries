# Phase 5 — Third-Party Component Decision Matrix

| Component / Plugin | Typical Unify Usage | Decision | Replacement / Strategy | JS Required? | Rationale |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **Slider / Range** | Numeric range inputs | **REPLACE** | Native HTML `<input type="range">` + Blazor `@bind` | No | Semantic HTML5 control satisfies accessibility without dependencies. |
| **Hero / Content Slider** | Carousel slides | **REPLACE** | `PmCarousel.razor` (Bootstrap 5 Carousel) | Minimal (Bootstrap 5) | Oqtane-bundled Bootstrap 5 provides carousel capabilities natively. |
| **Slick / Owl Carousel** | Content/card carousels | **REMOVE** | `PmCarousel.razor` (Bootstrap 5 Carousel) | No | Redundant jQuery plugin; replaced by Blazor component. |
| **Fancybox / Magnific** | Image enlargement | **REPLACE** | `PmLightboxModal.razor` (Blazor + BS5 Modal) | Minimal (Bootstrap 5) | Blazor state handles active image index; avoids legacy DOM manipulation. |
| **CountTo / Counters** | Animated statistics | **REPLACE** | `PmAnimatedCounter.razor` (Blazor Timer) | No | Pure C# `PeriodicTimer` with cancellation and reduced-motion fallback. |
| **Select2 / Choices** | Form dropdowns | **REMOVE** | Native `<select>` + Bootstrap `.form-select` | No | Native browser dropdowns offer superior mobile and assistive accessibility. |
| **WOW.js / AOS** | Scroll reveal animation | **REMOVE** | CSS transitions & animations (`@keyframes`) | No | Replaced by pure CSS keyframes defined in `planet-ministries.css`. |
| **HSHeader / HSDropdown** | Header navigation | **REMOVE** | `PmHeader.razor` / `PmNavigation.razor` | No | Completed in Phase 3 using Blazor-native component hierarchy. |
| **Sticky Header JS** | Fixed navigation | **REPLACE** | CSS `position: sticky; top: 0;` | No | Modern CSS handles viewport docking cleanly without scroll event listeners. |
| **jQuery & Plugins** | DOM manipulation | **REMOVE** | Blazor Component State & Direct Binding | No | Fully eradicated from theme bundle in Phase 4. |
| **Forms Validation** | Input validation | **MIGRATE** | Blazor `EditForm` + `DataAnnotationsValidator` | No | Built-in Blazor validation framework replaces client-side JS scripts. |
| **Tooltips / Popovers** | Contextual hints | **REPLACE** | Bootstrap 5 Tooltips / Accessible HTML `title` | Minimal (Bootstrap 5) | Relies on authoritative Oqtane Bootstrap 5 runtime when necessary. |
| **Google Maps / Video** | Media embedding | **REPLACE** | Responsive `<iframe>` with `loading="lazy"` | No | Standard semantic markup eliminates external script dependencies. |