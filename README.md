# How to Create a Product Showcase Carousel in .NET MAUI

This demo shows how to build a product showcase in the .NET MAUI SfCarousel control.

This section explains how to create a visually rich product showcase using the .NET MAUI SfCarousel control with a custom item template. The carousel is bound to a collection of products and renders each item as a rounded card with an image and an overlay caption, making it ideal for highlighting featured or promotional items in your application.

The SfCarousel control is data-driven, so the items displayed in the showcase are generated dynamically from the bound collection. This approach helps create flexible, data-driven, and visually rich user interfaces while keeping the UI implementation clean and maintainable.

In this example, the carousel loads a collection of products (such as a smart watch, wireless headphones, laptop, smartphone, and digital camera) and renders them as swipeable cards. Each card uses a gradient background, rounded corners, a drop shadow, and a semi-transparent label overlay that displays the product name on top of the product image.

## Key Highlights

- Displays a swipeable product showcase using the SfCarousel control.
- Renders each product as a rounded card with image and overlay caption.
- Uses data binding to populate the carousel from an ObservableCollection.
- Supports a custom DataTemplate to fully control the visual layout of each item.
- Applies a soft gradient background, drop shadow, and rounded corners for a modern look.
- Built on the MVVM pattern for a clean separation of data and UI.

By following the implementation steps, you can easily customize the appearance of each carousel item and create rich shopping or catalog experiences based on your application data.
