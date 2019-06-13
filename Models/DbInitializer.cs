using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practive_shop.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Pies.Any())
            {
                context.AddRange(
                        new Pie
                        {
                            
                            Name = "Apple Pie",
                            Price = 12.95M,
                            ShortDescription = "Our famous apple pies",
                            LongDescription = "This is apple long description",
                            IsPieOfTheWeek = false,
                            ImageUrl = "https://picsum.photos/200/300"
                        },
                        new Pie
                        {
                           
                            Name = "Orange Pie",
                            Price = 12.95M,
                            ShortDescription = "Our famous Orange pies",
                            LongDescription = "This is Orange long description",
                            IsPieOfTheWeek = false,
                            ImageUrl = "https://picsum.photos/200/300/?blur",
                        },
                        new Pie
                        {
                           
                            Name = "Cherry Pie",
                            Price = 12.95M,
                            ShortDescription = "Our famous apple pies",
                            LongDescription = "This is Cherry long description",
                            ImageUrl = "https://picsum.photos/200/300?grayscale",
                            IsPieOfTheWeek = true
                        },
                        new Pie
                        {
                            
                            Name = "Cheese Pie",
                            Price = 12.95M,
                            ShortDescription = "Our famous Cheese pies",
                            LongDescription = "This is Cheese long description",
                            ImageUrl = "https://picsum.photos/200/300?grayscale",
                            IsPieOfTheWeek = false
                        }
                    );

                context.SaveChanges();
            }
        }
    }
}
