using System;
using System.Collections.Generic;

//everything is in the namespace so Building can be called in City.cs
namespace Planner {

    public class City {

        public string Name { get; set; }
        public string Mayor { get; set; }

        public int Year { get; set; }

        public List<Building> _listBuildings = new List<Building> ();

        //the type first(Building) and then the new parameter name
        //creating a method for adding a new building to _listBuildings 
        public void AddBuilding (Building newBuilding)

        {
            _listBuildings.Add (newBuilding);
        }

    }

}