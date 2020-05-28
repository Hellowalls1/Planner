using System;

namespace Planner {
    class Program {
        static void Main (string[] args) {

            Building thespot = new Building ("512 8th Avenue") {

                //

                Width = 300,
                Depth = 3000,
                Stories = 30

            };

            thespot.Construct ();
            thespot.Purchase ("Grandpa");

            Console.WriteLine (thespot);
        }
    }

}