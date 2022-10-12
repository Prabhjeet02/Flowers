using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Flowers.Data;

namespace Flowers.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcFlowersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcFlowersContext>>()))
            {
                // Look for any Flowers.
                if (context.Flower.Any())
                {
                    return;   // DB has been seeded
                }

                context.Flower.AddRange(
                    new Flower
                    {
                        Name = "Rose",
                        sellingDate = DateTime.Parse("2022-2-12"),
                        Color = "Red",
                        Price = 7.99M,
                        Quantity = 2,
                        CustomerReview = "exellent"
                    },
                    new Flower
                    {
                        Name = "Sun Flower",
                        sellingDate = DateTime.Parse("2022-3-17"),
                        Color = "Yellow",
                        Price = 5.00M,
                        Quantity = 5,
                        CustomerReview = "good"
                    }, 
                    new Flower
                    {
                        Name = "Lily",
                        sellingDate = DateTime.Parse("2021-2-19"),
                        Color = "White",
                        Price = 8.99M,
                        Quantity = 20,
                        CustomerReview = "very good"
                    },
                    new Flower
                    {
                        Name = "Tulip",
                        sellingDate = DateTime.Parse("2022-8-22"),
                        Color = "Pink",
                        Price = 5.44M,
                        Quantity = 10,
                        CustomerReview = "good"
                    },
                    new Flower
                    {
                        Name = "Rose",
                        sellingDate = DateTime.Parse("2022-10-12"),
                        Color = "White",
                        Price = 10.77M,
                        Quantity = 8,
                        CustomerReview = "average"
                    },
                    new Flower
                    {
                        Name = "Tulip",
                        sellingDate = DateTime.Parse("2022-9-22"),
                        Color = "Red",
                        Price = 6.77M,
                        Quantity = 15,
                        CustomerReview = "good"
                    },
                    new Flower
                    {
                        Name = "Orchid",
                        sellingDate = DateTime.Parse("2022-9-17"),
                        Color = "Blue",
                        Price = 4.55M,
                        Quantity = 14,
                        CustomerReview = "Poor"
                    },
                    new Flower
                    {
                        Name = "Rose",
                        sellingDate = DateTime.Parse("2020-3-27"),
                        Color = "Black",
                        Price = 9.99M,
                        Quantity = 8,
                        CustomerReview = "very good"
                    },
                    new Flower
                    {
                        Name = "Orchid",
                        sellingDate = DateTime.Parse("2020-8-24"),
                        Color = "Red",
                        Price = 7.99M,
                        Quantity = 8,
                        CustomerReview = "good"
                    }, 
                    new Flower
                    {
                        Name = "Lily",
                        sellingDate = DateTime.Parse("2021-2-22"),
                        Color = "Blue",
                        Price = 4.99M,
                        Quantity = 9,
                        CustomerReview = "average"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
