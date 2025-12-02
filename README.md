# MVCLOggingLocalization

An ASP.NET Core MVC demonstration project showcasing Razor Views, Tag Helpers, and various view-related features.

## Features

- Razor Syntax - Expressions, control structures, code blocks
- Tag Helpers - Built-in and custom tag helpers
- View Data Passing - ViewData, ViewBag, TempData
- Partial Views - Reusable view components
- Form Validation - Client and server-side validation
- Localization - Multi-language support (English, Bengali)
- Layout Sections - RenderBody, RenderSection

## Project Structure

```
MVCViewsDemo/
├── Controllers/
│   ├── HomeController.cs
│   ├── ProductsController.cs
│   ├── ContactController.cs
│   ├── DataDemoController.cs
│   └── TagHelpersController.cs
├── Models/
│   ├── Product.cs
│   ├── ContactFormModel.cs
│   └── ErrorViewModel.cs
├── TagHelpers/
│   ├── AlertTagHelper.cs
│   ├── BadgeTagHelper.cs
│   ├── EmailTagHelper.cs
│   ├── ProgressBarTagHelper.cs
│   └── TimeAgoTagHelper.cs
├── Views/
│   ├── Home/
│   ├── Products/
│   ├── Contact/
│   ├── DataDemo/
│   ├── TagHelpers/
│   └── Shared/
│       ├── _Layout.cshtml
│       ├── _Alert.cshtml
│       ├── _Pagination.cshtml
│       ├── _ProductCard.cshtml
│       └── _ValidationScriptsPartial.cshtml
├── Resources/
│   └── Views/DataDemo/
│       ├── Localization.en.resx
│       └── Localization.bn.resx
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
└── Program.cs
```

## Pages

| Page	| Description |
|-------|-------------|
| Home	| Razor syntax demo with expressions, loops, conditionals |
| Products	| Product catalog with partial views and sidebar |
| Contact	| Form with validation using Form Tag Helpers |
| Data Demo	| ViewData, ViewBag, TempData examples |
| Localization	| Multi-language support demo |
| Tag Helpers | Built-in and custom Tag Helper examples |