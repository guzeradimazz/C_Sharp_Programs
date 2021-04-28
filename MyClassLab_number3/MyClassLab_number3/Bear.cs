using System;
namespace MyClassLab_number3
{
    class Bear : AnimalClass, IAnimalAffairs
    {
        public Bear(int strenght)
        {
            SleeppingHours = 0;
            this.strenght = strenght;
            Habitat = "All over the world";
            Nutrition = "Meat and green";
            MovementSpeed = 10;
            Color = color.Orange;
        }
        public Bear()
        {
            SleeppingHours = 0;
            strenght = 0;
            Habitat = "All over the world";
            Nutrition = "Meat and green";
            MovementSpeed = 10;
            Color = color.Orange;
        }
        public bool SleepAllWinter = false;
        public int SleeppingHours { get; set; }
        private int honey = 0, strenght;
        private Guid id = Guid.NewGuid();
        public void SleepDeep()
        {
            SleepAllWinter = true;
            strenght += 10;
            SleeppingHours += 4;
            Console.WriteLine("Bear is sleep 10hours!!!\nBear is ready to big day!");
        }
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
            if (SleepAllWinter)
            {
                Console.WriteLine($"This Bear is sleep all winter!!! This Bear is hungry");
            }
            Console.WriteLine("=========================================");
        }
        ~Bear(){}
    }
}
