---
name: Lumina Engineering
colors:
  surface: '#131313'
  surface-dim: '#131313'
  surface-bright: '#3a3939'
  surface-container-lowest: '#0e0e0e'
  surface-container-low: '#1c1b1b'
  surface-container: '#201f1f'
  surface-container-high: '#2a2a2a'
  surface-container-highest: '#353534'
  on-surface: '#e5e2e1'
  on-surface-variant: '#c8c5d2'
  inverse-surface: '#e5e2e1'
  inverse-on-surface: '#313030'
  outline: '#918f9b'
  outline-variant: '#464650'
  surface-tint: '#c1c1ff'
  primary: '#d4d3ff'
  on-primary: '#282869'
  primary-container: '#b4b4ff'
  on-primary-container: '#434386'
  inverse-primary: '#57579b'
  secondary: '#c8c6c5'
  on-secondary: '#313030'
  secondary-container: '#474746'
  on-secondary-container: '#b7b5b4'
  tertiary: '#f1d56d'
  on-tertiary: '#3b2f00'
  tertiary-container: '#d4b955'
  on-tertiary-container: '#594900'
  error: '#ffb4ab'
  on-error: '#690005'
  error-container: '#93000a'
  on-error-container: '#ffdad6'
  primary-fixed: '#e2dfff'
  primary-fixed-dim: '#c1c1ff'
  on-primary-fixed: '#120f54'
  on-primary-fixed-variant: '#3f3f81'
  secondary-fixed: '#e5e2e1'
  secondary-fixed-dim: '#c8c6c5'
  on-secondary-fixed: '#1c1b1b'
  on-secondary-fixed-variant: '#474746'
  tertiary-fixed: '#fee178'
  tertiary-fixed-dim: '#e1c560'
  on-tertiary-fixed: '#221b00'
  on-tertiary-fixed-variant: '#554500'
  background: '#131313'
  on-background: '#e5e2e1'
  surface-variant: '#353534'
typography:
  display-lg:
    fontFamily: Hanken Grotesk
    fontSize: 72px
    fontWeight: '800'
    lineHeight: '1.1'
    letterSpacing: -0.04em
  display-lg-mobile:
    fontFamily: Hanken Grotesk
    fontSize: 48px
    fontWeight: '800'
    lineHeight: '1.1'
    letterSpacing: -0.04em
  headline-md:
    fontFamily: Hanken Grotesk
    fontSize: 32px
    fontWeight: '700'
    lineHeight: '1.2'
    letterSpacing: -0.02em
  body-lg:
    fontFamily: Inter
    fontSize: 18px
    fontWeight: '400'
    lineHeight: '1.6'
    letterSpacing: 0em
  body-md:
    fontFamily: Inter
    fontSize: 16px
    fontWeight: '400'
    lineHeight: '1.6'
    letterSpacing: 0em
  label-sm:
    fontFamily: Geist
    fontSize: 14px
    fontWeight: '500'
    lineHeight: '1'
    letterSpacing: 0.05em
  code-md:
    fontFamily: Geist
    fontSize: 14px
    fontWeight: '400'
    lineHeight: '1.5'
rounded:
  sm: 0.125rem
  DEFAULT: 0.25rem
  md: 0.375rem
  lg: 0.5rem
  xl: 0.75rem
  full: 9999px
spacing:
  unit: 4px
  container-max: 1280px
  gutter: 24px
  margin-mobile: 20px
  margin-desktop: 64px
  stack-sm: 8px
  stack-md: 24px
  stack-lg: 48px
---

## Brand & Style

This design system is built for the modern developer-creator: a fusion of technical rigor and minimalist aesthetics. The brand personality is "Precision-Driven Sophistication," emphasizing clarity, performance, and high-end craftsmanship.

The visual style is **Dark Minimalist Developer Aesthetic**. It leverages a deep, void-like background to make content pop, paired with high-contrast typography and a singular accent color. It draws inspiration from premium developer tools and architectural minimalism, utilizing generous whitespace and razor-sharp alignment to convey a sense of intentionality and engineering excellence.

## Colors

The palette is strictly controlled to maintain a high-performance, focused environment. 

- **Primary:** A soft, desaturated lavender (#B4B4FF) used sparingly for high-impact calls to action, focus states, and key brand highlights.
- **Surface:** The background is a true deep-dark gray (#0A0A0A), creating a perfect canvas for high-contrast text.
- **Secondary/Stroke:** Medium grays (#1A1A1A) are used for subtle borders, dividers, and secondary button backgrounds to maintain hierarchy without cluttering the visual field.
- **Typography:** Pure white is reserved for headings to ensure maximum legibility, while a muted silver-gray is used for body text to reduce eye strain in dark mode.

## Typography

The typographic system prioritizes "Geometrical Precision." **Hanken Grotesk** is used for display and headings to provide a bold, contemporary feel with tight kerning. **Inter** handles body copy for its exceptional readability at small sizes and neutral character. **Geist** is introduced for labels and technical data, providing a monospaced "developer" feel that reinforces the engineering narrative.

Hierarchy is established through extreme weight contrast (Extra Bold vs. Regular) and scale. Display text should use negative letter-spacing to feel "locked-in" and architectural.

## Layout & Spacing

This design system utilizes a **12-column fixed grid** for desktop and a **4-column fluid grid** for mobile. The layout philosophy is centered on asymmetrical balance and "The Void"—using large areas of empty space to direct attention to core messaging.

- **Grid:** On desktop, the central container is capped at 1280px to maintain line-length readability.
- **Rhythm:** Spacing follows a strict 4px base unit. Component padding is generous to ensure a premium, uncrowded feel.
- **Alignment:** Elements are strictly snapped to the grid. Avoid center-alignment for large blocks of text; left-alignment reinforces the technical, structured aesthetic.

## Elevation & Depth

In a dark minimalist system, traditional shadows are avoided in favor of **Tonal Layering** and **Subtle Outlines**.

- **Depth:** Higher elevation is communicated by lightening the surface color. A card at "Level 1" uses #111111, while a hover state or modal at "Level 2" uses #1A1A1A.
- **Borders:** Use 1px solid borders in #262626 (or lower opacity white) to define container edges. This creates a "blueprint" or "wireframe" feel.
- **Glassmorphism:** Reserved strictly for navigation bars and floating overlays. Use a `12px` backdrop blur with a `10%` white opacity fill to create a frosted lens effect over the dark background.

## Shapes

The shape language is "Soft-Precision." While the system feels geometric, a small 4px (Soft) radius is applied to buttons and containers to make the interface feel approachable and modern rather than aggressive.

- **Standard Radius:** 4px (0.25rem) for all buttons, inputs, and small cards.
- **Large Radius:** 8px (0.5rem) for main content sections or hero imagery containers.
- **Interactive States:** On hover, shapes should remain consistent; focus states should utilize a 2px offset solid stroke in the primary lavender color.

## Components

### Buttons
- **Primary:** Solid Primary Lavender (#B4B4FF) background with Black (#0A0A0A) text. No shadow. Bold weight.
- **Secondary:** Transparent background with a 1px solid Primary or White stroke. 
- **Tertiary:** Ghost style, text only with an underline appearing on hover.

### Input Fields
- Dark backgrounds (#111111) with a subtle 1px stroke. 
- Labels use the monospaced font in uppercase for a technical, data-entry feel.
- Focus state: Stroke changes to Primary Lavender with no glow/shadow.

### Cards
- Cards do not use shadows. They are defined by a 1px border (#1A1A1A).
- Inner padding should be consistent (32px for desktop, 24px for mobile).

### Chips & Tags
- Used for "Skills" or "Categories." Small text, monospaced font, 1px border, no background fill.

### Navigation
- Top-aligned, fixed position. Uses a backdrop-blur effect. 
- Links are muted gray, transitioning to White on hover with a small Primary Lavender dot indicator.