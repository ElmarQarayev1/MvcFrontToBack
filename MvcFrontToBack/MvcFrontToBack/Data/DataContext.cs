using System;
using MvcFrontToBack.Models;

namespace MvcFrontToBack.Data
{
	public class DataContext
	{
		public List<Card> Cards = new List<Card>()
		{
			 new Card
			 {
				 Id=1,
				 Name="isler",
				 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Card
             {
                 Id=2,
                 Name="calismalar",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Card
             {
                 Id=3,
                 Name="is yerleri",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Card
             {
                 Id=4,
                 Name="datalar",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Card
             {
                 Id=5,
                 Name="melumatlar",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Card
             {
                 Id=5,
                 Name="is birlikleri",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
        };
        public List<Service> Services = new List<Service>()
        {
             new Service
             {
                 Id=1,
                 Name="pb302",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Service
             {
                 Id=2,
                 Name="pb301",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Service
             {
                 Id=3,
                 Name="pb300",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },


        };
        public List<Team> Teams = new List<Team>()
        {
            new Team
            {
                Id=1,
                Name="lady ibrahim",
                ShortDescription="telebe",
                LongDescription="universitet telebesi"
            },
            new Team
            {
                Id=2,
                Name="bigLady ibrahim",
                ShortDescription="telebe",
                LongDescription="universitet telebesi"
            },
            new Team
            {
                Id = 3,
                Name = "xanim ibrahim",
                ShortDescription = "telebe",
                LongDescription = "universitet telebesi"
            }
        };
       


    }
}

