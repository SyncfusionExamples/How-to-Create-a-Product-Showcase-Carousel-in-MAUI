using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProductShowCaseCarousel
{
    public class ProductViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>()
            {
                new Product
                {
                    Name = "Smart Watch",
                    Price = "$199",
                    Description = "Track fitness and stay connected.",
                    Image = "watch.png"
                },
                new Product
                {
                    Name = "Wireless Headphones",
                    Price = "$149",
                    Description = "Immersive sound with noise cancellation.",
                    Image = "headphone.png"
                },
                new Product
                {
                    Name = "Laptop",
                    Price = "$999",
                    Description = "Powerful performance for work and play.",
                    Image = "laptop.png"
                },
                new Product
                {
                    Name = "Smartphone",
                    Price = "$799",
                    Description = "Capture stunning photos and stay productive.",
                    Image = "smartphone.png"
                },
                new Product
                {
                    Name = "Digital Camera",
                    Price = "$649",
                    Description = "Professional quality photography and video.",
                    Image = "camera.png"
                }
            };
        }
    }

}
