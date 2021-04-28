using System;
namespace MyClassLab_number3
{
    class Worm : AnimalClass,ICloneable<Worm>
    {
        public Worm()
        {
            isHungry = true;
            Habitat = "Earth";
            Nutrition = "Minerals";
            MovementSpeed = 1;
            Color = color.Red;
        }
        public Worm(bool isHungry)
        {
            this.isHungry = isHungry;
            Habitat = "Earth";
            Nutrition = "Minerals";
            MovementSpeed = 1;
            Color = color.Red;
        }
        public Worm Clone()
        {
            return new Worm { Name = this.Name, Age = this.Age };
        }
        public string Name { get; set; }
        public int Age { get; set; }
        private Guid id = Guid.NewGuid();
        private bool isHungry;
        public void MoveUnderEarth()
        {
            if (isHungry)
            {
                Console.WriteLine("Worm can't move, Worm needs some eat");
                isHungry = false;
                Console.WriteLine($"Worm is eating {Nutrition} right now...");
            }
            Console.WriteLine($"Worm is moving rigth now with {MovementSpeed}m/s!!!");
            isHungry = true;
        }
        public void FastMoving(int speed)
        {
            isHungry = false;
            MovementSpeed = speed;
            Console.WriteLine($"Worm now is like Useyin Bold!!!\nMovement speed right now = {MovementSpeed}m/s");
            MovementSpeed = 1;
        }
        public void PrintInfoWorms()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Habitat of all worms : {Habitat}");
            Console.WriteLine($"Nutrition of all worms : {Nutrition}");
            Console.WriteLine($"MovementSpeed of worm : {MovementSpeed}m/s");
            Console.WriteLine($"Color of all worms : {Color}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine("=========================================");
        }
        ~Worm(){}
    }
}
