using CMSShopping.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSShopping.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CMSShoppingContext(serviceProvider.GetRequiredService<DbContextOptions<CMSShoppingContext>>()))
            {
                if (context.Pages.Any())
                {
                    return;
                }
                context.Pages.AddRange(
                    new Page
                    {
                        Title = "Home",
                        Slug = "home",
                        Content = "home page",
                        Sorting = 0
                    },
                    new Page
                    {
                        Title = "About Us",
                        Slug = "about-us",
                        Content = "about page",
                        Sorting = 100
                    },
                    new Page
                    {
                        Title = "Services",
                        Slug = "services",
                        Content = "Services page",
                        Sorting = 100
                    },
                    new Page
                    {
                        Title = "Contacts",
                        Slug = "contacts",
                        Content = "Contact page",
                        Sorting = 100
                    });

                context.SaveChanges();
            }
        }
    }
}
