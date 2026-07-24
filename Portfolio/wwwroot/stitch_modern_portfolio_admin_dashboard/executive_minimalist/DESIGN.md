---
name: Executive Minimalist
colors:
  surface: '#f8f9fa'
  surface-dim: '#d9dadb'
  surface-bright: '#f8f9fa'
  surface-container-lowest: '#ffffff'
  surface-container-low: '#f3f4f5'
  surface-container: '#edeeef'
  surface-container-high: '#e7e8e9'
  surface-container-highest: '#e1e3e4'
  on-surface: '#191c1d'
  on-surface-variant: '#414754'
  inverse-surface: '#2e3132'
  inverse-on-surface: '#f0f1f2'
  outline: '#717786'
  outline-variant: '#c1c6d7'
  surface-tint: '#005bc0'
  primary: '#0059bb'
  on-primary: '#ffffff'
  primary-container: '#0070ea'
  on-primary-container: '#fefcff'
  inverse-primary: '#adc7ff'
  secondary: '#575f67'
  on-secondary: '#ffffff'
  secondary-container: '#d8e1ea'
  on-secondary-container: '#5b646b'
  tertiary: '#9e3d00'
  on-tertiary: '#ffffff'
  tertiary-container: '#c64f00'
  on-tertiary-container: '#fffbff'
  error: '#ba1a1a'
  on-error: '#ffffff'
  error-container: '#ffdad6'
  on-error-container: '#93000a'
  primary-fixed: '#d8e2ff'
  primary-fixed-dim: '#adc7ff'
  on-primary-fixed: '#001a41'
  on-primary-fixed-variant: '#004493'
  secondary-fixed: '#dbe4ed'
  secondary-fixed-dim: '#bfc8d0'
  on-secondary-fixed: '#141d23'
  on-secondary-fixed-variant: '#3f484f'
  tertiary-fixed: '#ffdbcc'
  tertiary-fixed-dim: '#ffb695'
  on-tertiary-fixed: '#351000'
  on-tertiary-fixed-variant: '#7c2e00'
  background: '#f8f9fa'
  on-background: '#191c1d'
  surface-variant: '#e1e3e4'
typography:
  display-lg:
    fontFamily: Hanken Grotesk
    fontSize: 32px
    fontWeight: '700'
    lineHeight: '1.2'
    letterSpacing: -0.02em
  headline-md:
    fontFamily: Hanken Grotesk
    fontSize: 24px
    fontWeight: '600'
    lineHeight: '1.3'
  headline-sm:
    fontFamily: Hanken Grotesk
    fontSize: 20px
    fontWeight: '600'
    lineHeight: '1.4'
  body-lg:
    fontFamily: Inter
    fontSize: 16px
    fontWeight: '400'
    lineHeight: '1.6'
  body-md:
    fontFamily: Inter
    fontSize: 14px
    fontWeight: '400'
    lineHeight: '1.5'
  label-md:
    fontFamily: Inter
    fontSize: 12px
    fontWeight: '600'
    lineHeight: '1'
    letterSpacing: 0.05em
  label-sm:
    fontFamily: Inter
    fontSize: 11px
    fontWeight: '500'
    lineHeight: '1'
rounded:
  sm: 0.25rem
  DEFAULT: 0.5rem
  md: 0.75rem
  lg: 1rem
  xl: 1.5rem
  full: 9999px
spacing:
  sidebar_width: 260px
  header_height: 72px
  container_padding: 2rem
  card_gutter: 1.5rem
  stack_sm: 0.5rem
  stack_md: 1rem
---

## Brand & Style
The design system is engineered for a personal portfolio administration suite, emphasizing professional clarity, utility, and a sophisticated "Corporate Modern" aesthetic. It balances the pragmatism of a SaaS tool with the clean elegance required for a high-end personal brand.

The visual language is rooted in **Minimalism** with a focus on structured information hierarchy. It utilizes a cool-toned neutral foundation to allow user content and data visualizations to remain the focal point. The emotional response is one of organized efficiency, trust, and modern technical proficiency.

## Colors
This design system employs a high-utility palette dominated by a crisp white surface and a soft, greyish-white background. 

- **Primary Blue:** Used exclusively for high-priority actions, active navigation states, and brand-critical elements.
- **Neutrals:** A multi-layered grey scale is used to define hierarchy. `#F8F9FA` serves as the canvas, while `#E9ECEF` provides the thin, professional bordering seen in the reference dashboard.
- **Accents:** Semantic colors (Success, Warning, Danger) should be desaturated to maintain the professional, understated tone.

## Typography
The system uses **Hanken Grotesk** for headlines to provide a sharp, contemporary edge that distinguishes the brand. **Inter** is utilized for body text and UI labels due to its exceptional legibility in data-dense environments.

For table headers and small metadata, use `label-md` with uppercase styling to ensure clear separation between structural labels and dynamic content. Line heights are generous to prevent visual fatigue during long management sessions.

## Layout & Spacing
This design system follows a **Fixed-Fluid Hybrid** model. The sidebar remains fixed at `260px`, while the main content area utilizes a fluid grid that expands to fill the viewport, maintaining a maximum readable width of `1440px`.

- **Sidebar:** Vertical navigation with persistent visibility.
- **Top Bar:** Houses global search and user profile, fixed at the top of the viewport.
- **Content Area:** Standardized `2rem` padding around all main page contents.
- **Grid:** Use a 12-column system for dashboard widgets. Content should typically span 4, 6, or 12 columns to maintain alignment.

## Elevation & Depth
Depth is achieved through **Low-Contrast Outlines** and extremely subtle **Ambient Shadows**. 

- **Level 0 (Background):** `#F8F9FA` (flat).
- **Level 1 (Cards/Sidebar):** White surface, 1px solid `#E9ECEF` border.
- **Level 2 (Hover/Active):** A soft shadow with `0px 4px 12px rgba(0, 0, 0, 0.03)` to indicate interactivity without breaking the minimalist aesthetic.

Avoid heavy shadows or dark gradients; depth should feel architectural rather than decorative.

## Shapes
A consistent `0.5rem` (8px) corner radius is applied to all primary UI containers (cards, buttons, input fields). This provides a approachable yet structured feel. 

- **Standard Elements:** 8px radius.
- **Interactive Small Elements (Chips/Badges):** 4px radius for higher precision.
- **Avatars:** Fully circular (pill-shaped) to distinguish human elements from functional UI.

## Components
- **Buttons:** Primary buttons use a solid Blue (`#007BFF`) fill with white text. Secondary buttons use a light grey ghost style with a subtle border.
- **Cards:** The core unit of the UI. Must have a white background, 1px border, and standardized padding (usually `1.5rem`).
- **Navigation Links:** Use a subtle background hover state (light blue tint). The active state should include a vertical "indicator bar" on the left edge as seen in the reference image.
- **Inputs:** Clean fields with `#F8F9FA` background and a 1px border that shifts to Blue on focus.
- **Tables:** Minimalist rows with no vertical lines. Use the `label-md` style for headers with a light blue-tinted background for the header row to separate it from the content.
- **Avatars:** Small profile images should be encased in a subtle border to ensure they pop against white surfaces.