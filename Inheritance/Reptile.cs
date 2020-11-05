using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            Legs = 4;
            HasFur = false;
        }

        public string Name { get; set; }
        public bool CanBeAPet { get; set; }
        public string Habitat { get; set; }
        public string Region { get; set; }
        public bool HasTail { get; set; }

        public void DescribeReptile()
        {
            Console.WriteLine($"The {Name} lives in {Region} in a {Habitat} environment. It has {Legs} legs.");
        }
    }
}
