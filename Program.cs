using System;

namespace Planner {
    class Program {
        static void Main (string[] args) {

            City Crawfordsville = new City () {

                Name = "Crawfordsville",
                Mayor = "Sam Stone",
                Year = 1989

            };

            Building theSpot = new Building ("512 8th Avenue") {

                //

                Width = 300,
                Depth = 3000,
                Stories = 30

            };

            Building theTallOne = new Building ("1008 Main St") {

                Width = 200,
                Depth = 2000,
                Stories = 20
            };

            Building theShortOne = new Building ("2012 West 4th St.") {

                Width = 200,
                    Depth = 2000,
                    Stories = 20

            }

            theSpot.Construct ();
            theSpot.Purchase ("Grandpa");
            theTallOne.Construct ();
            theTallOne.Purchase ("Mom");
            Console.WriteLine (theSpot);
            Console.WriteLine (theTallOne);

            Crawfordsville.AddBuilding (theSpot);
        }
    }

}