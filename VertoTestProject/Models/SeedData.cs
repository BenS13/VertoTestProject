using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VertoTestProject.Data;

namespace VertoTestProject.Models
{
    //This is the class that will seed the database with the initial data for the home page

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ContentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ContentContext>>()))
            {
                //Look for any content in the database
                if (context.Contents.Any())
                {
                    return; //Db has already been seeded
                }
                context.Contents.AddRange(
                    new Content
                    {
                        Title = "New Products",
                        ImageURL = "~/images/new_prodcuts.png",
                        Description = "Lorem ipsum dolor sit amet. Qui sequi nihil qui consectetur sapiente eos explicabo ullam sed omnis earum et Quis illo ea modi sunt."
                    },
                    new Content
                    {
                        Title = "Field Events",
                        ImageURL = "~/images/field_events.png",
                        Description = "Lorem ipsum dolor sit amet. Qui sequi nihil qui consectetur sapiente eos explicabo ullam sed omnis earum et Quis illo ea modi sunt."
                    },
                    new Content
                    {
                        Title = "Latest News",
                        ImageURL = "~/images/latest_news.png",
                        Description = "Lorem ipsum dolor sit amet. Qui sequi nihil qui consectetur sapiente eos explicabo ullam sed omnis earum et Quis illo ea modi sunt."
                    },
                    new Content
                    {
                        Title = "Gallery",
                        ImageURL = "~/images/gallery.png",
                        Description = "Lorem ipsum dolor sit amet. Qui sequi nihil qui consectetur sapiente eos explicabo ullam sed omnis earum et Quis illo ea modi sunt."
                    },
                    new Content
                    {
                        Title = "Special Offers",
                        ImageURL = "~/images/cashback_offer.png",
                        Description = "Discovery WP PC, £20 Cashback",
                    },
                    new Content
                    {
                        Title = "Special Offers",
                        ImageURL = "~/images/digiscoping_kit.png.png",
                        Description = "HR ED Fieldscopes, Free Digiscoping Kit"
                    },
                    new Content
                    {
                        Title = "Special Offers",
                        ImageURL = "~/images/fieldscope_kit.png",
                        Description = "IS 60 WP Fieldscope Kits, Save 25%"
                    },
                    new Content
                    {
                        Title = "Product Categories",
                        ImageURL = "~/images/binoculars.png",
                        Description = "Binoculars"
                    },
                    new Content
                    {
                        Title = "Product Categories",
                        ImageURL = "~/images/compact_binoculars.png",
                        Description = "Compact Binoculars"
                    },
                    new Content
                    {
                        Title = "Product Categories",
                        ImageURL = "~/images/telescope.png",
                        Description = "Telescopes & Eyepeices"
                    },
                    new Content
                    {
                        Title = "Product Categories",
                        ImageURL = "~/images/observation_marine.png",
                        Description = "Observation and Marine"
                    }

                    );
                    context.SaveChanges();
            }
        }
    }
}
