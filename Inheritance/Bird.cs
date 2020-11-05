using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            HasFur = false;
        }

        public string BirdName { get; set; }
        public bool CanFly { get; set; }
        public bool Migrates { get; set; }
        public bool MakesNest { get; set; }
        public bool Huntable { get; set; }
       

       
    }
    
}

