---
name: Professional Admin
colors:
  surface: '#f9f9ff'
  surface-dim: '#cfdaf2'
  surface-bright: '#f9f9ff'
  surface-container-lowest: '#ffffff'
  surface-container-low: '#f0f3ff'
  surface-container: '#e7eeff'
  surface-container-high: '#dee8ff'
  surface-container-highest: '#d8e3fb'
  on-surface: '#111c2d'
  on-surface-variant: '#424656'
  inverse-surface: '#263143'
  inverse-on-surface: '#ecf1ff'
  outline: '#737687'
  outline-variant: '#c2c6d9'
  surface-tint: '#0052dc'
  primary: '#004bca'
  on-primary: '#ffffff'
  primary-container: '#0061ff'
  on-primary-container: '#f1f2ff'
  inverse-primary: '#b4c5ff'
  secondary: '#505f76'
  on-secondary: '#ffffff'
  secondary-container: '#d0e1fb'
  on-secondary-container: '#54647a'
  tertiary: '#005c85'
  on-tertiary: '#ffffff'
  tertiary-container: '#0076a9'
  on-tertiary-container: '#eaf4ff'
  error: '#ba1a1a'
  on-error: '#ffffff'
  error-container: '#ffdad6'
  on-error-container: '#93000a'
  primary-fixed: '#dbe1ff'
  primary-fixed-dim: '#b4c5ff'
  on-primary-fixed: '#00174b'
  on-primary-fixed-variant: '#003ea8'
  secondary-fixed: '#d3e4fe'
  secondary-fixed-dim: '#b7c8e1'
  on-secondary-fixed: '#0b1c30'
  on-secondary-fixed-variant: '#38485d'
  tertiary-fixed: '#c9e6ff'
  tertiary-fixed-dim: '#89ceff'
  on-tertiary-fixed: '#001e2f'
  on-tertiary-fixed-variant: '#004c6e'
  background: '#f9f9ff'
  on-background: '#111c2d'
  surface-variant: '#d8e3fb'
typography:
  display-lg:
    fontFamily: Inter
    fontSize: 57px
    fontWeight: '700'
    lineHeight: 64px
    letterSpacing: -0.25px
  headline-lg:
    fontFamily: Inter
    fontSize: 32px
    fontWeight: '600'
    lineHeight: 40px
    letterSpacing: 0px
  headline-md:
    fontFamily: Inter
    fontSize: 28px
    fontWeight: '600'
    lineHeight: 36px
    letterSpacing: 0px
  title-lg:
    fontFamily: Inter
    fontSize: 22px
    fontWeight: '500'
    lineHeight: 28px
    letterSpacing: 0px
  title-md:
    fontFamily: Inter
    fontSize: 16px
    fontWeight: '500'
    lineHeight: 24px
    letterSpacing: 0.15px
  body-lg:
    fontFamily: Inter
    fontSize: 16px
    fontWeight: '400'
    lineHeight: 24px
    letterSpacing: 0.5px
  body-md:
    fontFamily: Inter
    fontSize: 14px
    fontWeight: '400'
    lineHeight: 20px
    letterSpacing: 0.25px
  label-lg:
    fontFamily: Inter
    fontSize: 14px
    fontWeight: '500'
    lineHeight: 20px
    letterSpacing: 0.1px
  label-sm:
    fontFamily: Inter
    fontSize: 11px
    fontWeight: '500'
    lineHeight: 16px
    letterSpacing: 0.5px
rounded:
  sm: 0.25rem
  DEFAULT: 0.5rem
  md: 0.75rem
  lg: 1rem
  xl: 1.5rem
  full: 9999px
spacing:
  sidebar-width: 240px
  navbar-height: 64px
  container-padding: 24px
  gutter: 16px
  stack-sm: 8px
  stack-md: 16px
  stack-lg: 24px
---

## Brand & Style

This design system is a refined implementation of **Material Design 3**, specifically optimized for a personal portfolio administrative interface. The personality is **Professional, Systematic, and Efficient**. It prioritizes clarity and utility, ensuring the user can manage content with minimal cognitive load. 

The aesthetic adheres to **Modern Minimalism** with a focus on structured information hierarchy. It avoids decorative elements like gradients or heavy shadows in favor of subtle borders, purposeful white space, and a high-contrast typographic scale. The goal is to evoke a sense of reliability and precision, reflecting the high standards of a professional creative or developer's portfolio.

## Colors

The palette is anchored by a high-energy **Bright Blue (#0061FF)** primary color used for action-oriented elements and branding. The background is a cool **Light Blue-Gray (#F8FAFC)** to reduce eye strain during long editing sessions, while interactive surfaces utilize **Clean White (#FFFFFF)** to create clear physical separation.

- **Primary**: Used for main buttons, active states, and focus indicators.
- **Surface**: Used for cards, navigation panels, and modals.
- **Outline**: A subtle gray used for borders to define structure without adding visual noise.
- **On-Surface**: Text uses a deep gray-blue to maintain high readability while feeling softer than pure black.
- **Semantic**: Success states use the primary blue; "Draft" or "Inactive" states utilize a neutral gray-scale.

## Typography

The design system uses **Inter** across all levels to ensure maximum legibility and a contemporary, technical feel. 

- **Language Support**: All typographic components must support Turkish characters (ç, ğ, ı, ö, ş, ü).
- **Scale**: Headlines use a semi-bold weight (600) to stand out against the light UI. Body text defaults to 14px (body-md) for data density, while 16px (body-lg) is reserved for long-form content.
- **Labels**: Used for buttons, navigation items, and table headers. These use a medium weight (500) to distinguish them from standard body text.

## Layout & Spacing

The layout follows a **Fixed-Fluid model** typical of administrative dashboards.

- **Sidebar**: A fixed 240px left-hand column containing the main navigation. It uses a surface-level color to separate it from the main content.
- **Navbar**: A fixed 64px top bar for global search, notifications, and profile management.
- **Content Area**: A fluid region that occupies the remaining viewport width. It uses a 24px padding (container-padding) to ensure content doesn't touch the edges of the browser.
- **Grid**: Within the content area, cards and data tables follow a modular grid system with 16px (gutter) spacing between elements.
- **Responsive Behavior**: On screens smaller than 1024px, the sidebar transitions to a hidden "drawer" state toggled by a hamburger menu in the navbar.

## Elevation & Depth

This design system uses a **Low-Contrast Elevation** strategy to maintain a flat, professional aesthetic. 

- **Level 0 (Background)**: `#F8FAFC` - The lowest layer.
- **Level 1 (Cards/Sidebar)**: White surfaces with a 1px border of `#E2E8F0`. 
- **Shadows**: Only one shadow style is used: a soft, diffused "Ambient Shadow" for floating elements like dropdowns or active cards. 
  - *Shadow Token:* `0 4px 6px -1px rgb(0 0 0 / 0.1), 0 2px 4px -2px rgb(0 0 0 / 0.1)`
- **Hover States**: Tables and interactive list items should use a subtle background tint of `#F1F5F9` rather than elevation changes to indicate focus.

## Shapes

The design system utilizes **Rounded** corners to soften the professional aesthetic and make the interface feel modern.

- **Standard Radius**: 0.5rem (8px) for input fields, buttons, and small containers.
- **Card Radius**: 1rem (16px) specifically for main content containers to create a distinct Material 3 "container" look.
- **Badge Radius**: Pill-shaped (fully rounded) for status indicators like "Aktif" or "Taslak".

## Components

### Buttons
- **Primary**: Background `#0061FF`, Text `#FFFFFF`, 8px radius.
- **Secondary**: Transparent background, border `#E2E8F0`, Text `#1E293B`.
- **Text**: Turkish labels (e.g., "Kaydet", "Vazgeç", "Düzenle").

### Cards
- White background, 16px radius, 1px border (`#E2E8F0`).
- Use 24px internal padding for content.

### Data Tables
- Header: Background `#F8FAFC`, Text `label-lg` (Turkish).
- Row Hover: Background `#F1F5F9`.
- Borders: Horizontal only, `#E2E8F0`.

### Badges (Status)
- **Aktif/Çevrimiçi**: Background `rgba(0, 97, 255, 0.1)`, Text `#0061FF`.
- **Taslak**: Background `#F1F5F9`, Text `#64748B`.

### Input Fields
- Bordered style, `#E2E8F0` stroke.
- Focus state: 2px border `#0061FF`.
- Labels should use Turkish prompts (e.g., "Kullanıcı Adı", "Açıklama").

### Icons
- Use **Material Symbols Outlined**.
- Default size: 20px for sidebar, 24px for main actions.