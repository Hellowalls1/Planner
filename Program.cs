using System;

namespace Planner {
    class Program {
        static void Main (string[] args) {

            //representation of a city

            City Crawfordsville = new City () {

                Name = "Crawfordsville",
                Mayor = "Sam Stone",
                Year = 1989

            };

            //representation of a building
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

            Building theShortOne = new Building ("2012 West 4th St") {

                Width = 200,
                Depth = 2000,
                Stories = 20

            };

            //construct is adding the date the item is constructed
            //purchase is who purchased the shiz
            theSpot.Construct ();
            theSpot.Purchase ("Grandpa");

            theTallOne.Construct ();
            theTallOne.Purchase ("Mom");

            theShortOne.Construct ();
            theShortOne.Purchase ("Michael Bolton");

            //displaying the building in the terminal
            // Console.WriteLine (theSpot);
            // Console.WriteLine (theTallOne);
            // Console.WriteLine (theShortOne);

            //adding the building to the city
            Crawfordsville.AddBuilding (theSpot);
            Crawfordsville.AddBuilding (theTallOne);
            Crawfordsville.AddBuilding (theShortOne);

            foreach (Building building in Crawfordsville._listBuildings) {
                Console.WriteLine (building);
            };
        }
    }

}