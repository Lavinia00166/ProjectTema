using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTema
{
    class City
    {
        public string name;
        Streets street;
        Buildings building;
        Schools school;
        Parks park;
        

        public City(String name, Streets street, Buildings building, Schools school, Parks park)
        {
            this.name = name; 
            this.street = street;
            this.building = building;
            this.school = school; 
            this.park = park; 
        }

        public string ToString() { return " The name of the city is " + name +  ". " + street.ToString() + park.ToString() + school.ToString(); }

    }
    public class Streets
    {
        private string name;
        private Buildings building;
    
        public Streets(string name, Buildings building)
        {   
            this.name = name; 
            this.building = building; 
         }
        public string ToString() { return "It has more streets, one of them is named: " + name  + building.ToString(); }
    }
    public class Parks
    {
        private string name;
        private int dimension;
        public Parks(string name, int dimension)
        {
            this.name = name; 
            this.dimension = dimension;

        }
        public string ToString() { return " and a park " + name + " with a dimension of " + dimension + " meters." ; }
    }

    public class Buildings
    {
        public string category;
        public int floors;
        public Buildings(string category, int floors)
        {
            this.category = category;
            this.floors = floors;

        }
        public string ToString() { return " and it has three buildings, one is a " + category + " that has " +  floors + " floors" ; }


    }
    public class Schools
    {
        public string name;
        public int classes;
        public int students; 
       
        public Schools(string name, int classes, int students)
        {
            this.name = name;
            this.classes = classes;
            this.students = students;
        }
        public string ToString() { return " It also has a school, it's name is " + name + " with " + classes + " classes and " + students + "  students. "; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Schools school = new Schools("Troy High School", 25, 500);
            Buildings building = new Buildings("Firm", 12);
            Streets street = new Streets("Lancaster Street", building );
            Parks park = new Parks("Central Park", 350);
            City city = new City("New York", street, building, school, park);
            Console.WriteLine(city.ToString());
        }
    }
}
