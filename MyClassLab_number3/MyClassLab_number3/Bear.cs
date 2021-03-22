using System;
namespace MyClassLab_number3
{
    class Bear : AnimalClass
    {
        public Bear(int strenght)
        {
            this.strenght = strenght;
            Habitat = "All over the world";
            Nutrition = "Meat and green";
            MovementSpeed = 10;
            Color = color.Orange;
        }
        public Bear()
        {
            strenght = 0;
            Habitat = "All over the world";
            Nutrition = "Meat and green";
            MovementSpeed = 10;
            Color = color.Orange;
        }
        private int honey = 0, strenght;
        private Guid id = Guid.NewGuid();
        public void sleep()
        {
            strenght++;
        }
        public void fightWithBee()
        {
            if (strenght == 0)
            {
                Console.WriteLine("Bear is too tired(Simply call function sleep())");
            }
            else
            {
                Console.WriteLine("Bear is fighting with bee's rigth now!!!");
                Console.WriteLine("Bear get some honey(+1)\nBut he is too tired");
                honey++;
                strenght = 0;
            }
        }
        public void printInfo()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Habitat of all Bear's : {Habitat}");
            Console.WriteLine($"Nutrition of all Bear's : {Nutrition}");
            Console.WriteLine($"MovementSpeed of all Bear's : {MovementSpeed}m/s");
            Console.WriteLine($"Color of all Bear's : {Color}");
            Console.WriteLine($"This Bear for all lifetime collect : {honey} liters of honey");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine("=========================================");
        }
        ~Bear(){}
    }
}
