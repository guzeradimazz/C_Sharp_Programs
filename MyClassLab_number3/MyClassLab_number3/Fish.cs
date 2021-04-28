using System;
namespace MyClassLab_number3
{
    class Fish : AnimalClass,IAnimalAffairs
    {
        public Fish()
        {

            Habitat = "Water";
            Nutrition = "Green and fishes";
            MovementSpeed = 20;
            Color = color.Blue;
        }
        public int SleeppingHours { get; set; }
        private int children = 0;
        private Guid id = Guid.NewGuid();
        private bool isHungry = true;
        public void SleepDeep()
        {
            children += 10;
            SleeppingHours += 4;
            Console.WriteLine($"This fish is sleepping a lot of time!\nRight now this fish have {children} childs");
        }
        public void eatGreen()
        {
            isHungry = false;
            Console.WriteLine("Fish is eating right now!");
        }
        public void reproduction()
        {
            if (!isHungry)
            {
                Console.WriteLine("Fish is ready to reproducing");
                children++;
                Console.WriteLine("Fish reproduce 1 children");
            }
            else
            {
                Console.WriteLine("Fish is to hungry\nJust call function eatGreen()");
            }
        }
        public void printInfo()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Habitat of all Fishes : {Habitat}");
            Console.WriteLine($"Nutrition of all Fishes : {Nutrition}");
            Console.WriteLine($"MovementSpeed of all Fishes : {MovementSpeed}m/s");
            Console.WriteLine($"Color of all Fishes : {Color}");
            Console.WriteLine($"Childrens of this Fish : {children}");
            Console.WriteLine($"ID: {id}");
            if (SleeppingHours > 0)
            {
                Console.WriteLine($"This fish sleeps {SleeppingHours} hours");
            }
            Console.WriteLine("=========================================");
        }
        public virtual void swimming()
        {
            Console.WriteLine("Fish is swimming");
        }
        ~Fish(){}
    }
    class Caras : Fish
    {
        public int fishesEated = 0;
        public void eatOtherFish()
        {
            fishesEated++;
        }
        public void getEatedFishes()
        {
            Console.WriteLine($"This caras eated {fishesEated} fishes");
        }
        public override void swimming()
        {
            Console.WriteLine("I swim like CARAS");
        }
    }
    class Schuka : Fish
    {
        public override void swimming()
        {
            Console.WriteLine("I swim like SCHUKA");
        }
    }
}
