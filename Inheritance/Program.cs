using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            var seagull = new Bird();
            seagull.Color = "white";
            seagull.isNice = false;
            seagull.Migrates = true;
            seagull.MakesNest = true;
            seagull.CanFly = true;
            seagull.BirdName = "seagull";

            DescribeBird(seagull);


            var alligator = new Reptile();
            alligator.Name = "alligator";
            alligator.Habitat = "swamps, rivers, and lakes";
            alligator.Region = " the southeastern United States";

            alligator.DescribeReptile();
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            
        }
        public static void DescribeBird(Bird bird)
        {
            Console.WriteLine($"The {bird.BirdName} is a {bird.Color} bird that \n" +
                $"Can Fly: {bird.CanFly}\nMigrates: {bird.Migrates}\nMakes a nest: {bird.MakesNest}\n" +
                $"Is kind to people: {bird.isNice}");
            }
    }
}
