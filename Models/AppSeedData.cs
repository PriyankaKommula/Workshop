using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;


namespace WebApplication6.Models
{
    public static class AppSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            var context = serviceProvider.GetService<ApplicationDbContext>();
            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }
            var seasons = new List<Season>
           {
               new Season {SeasonName=3,TimePeriod=6 }
           };
             context.Seasons.AddRange(seasons);
            context.SaveChanges();
            var context1 = serviceProvider.GetService<ApplicationDbContext>();
            var player = new List<Player>
            {
                new Player{PlayerName = "pp",SeasonId = seasons.Single(s => s.SeasonName == 3 ).SeasonId }
            };
            context1.Players.AddRange(player);
            context1.SaveChanges();

        }
    }
}