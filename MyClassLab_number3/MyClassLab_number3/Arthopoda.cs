using System;
namespace MyClassLab_number3
{
    class Arthopoda : AnimalClass
    {
        public Arthopoda(int killedFly)
        {
            this.killedFly = killedFly;
            killedInLifetime = killedFly; 
            Habitat = "Trees";
            Nutrition = "Insects";
            MovementSpeed = 5;
            Color = color.White;
        }
        public Arthopoda()
        {
            killedFly = 0;
            Habitat = "Trees";
            Nutrition = "Insects";
            MovementSpeed = 5;
            Color = color.White;
        }
        private int killedFly, killedInLifetime;
        private Guid id = Guid.NewGuid();
        public void weaveWeb()
        {
            if (killedFly == 0)
            {
                Console.WriteLine("This spider don't have enought fly's!\nYou need kill some fly's(Simply call function killFly()");
            }
            else
            {
                Console.WriteLine("Spider is weaving web...");
                Console.WriteLine("🕸🕸 🕸🕸 🕸🕸");
                Console.WriteLine(" 🕸🕸🕸🕸🕸🕸");
                Console.WriteLine("  🕸🕸🕷🕸🕸");
                Console.WriteLine("    🕸🕸🕸");
                Console.WriteLine("  🕸🕸🕸🕸🕸");
                Console.WriteLine("🕸🕸 🕸🕸 🕸🕸");
                killedFly = 0;
            }
        }
        public void killFly()
        {
            killedFly++;
            killedInLifetime++;
        }
        public void printInfo()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Habitat of all spider's : {Habitat}");
            Console.WriteLine($"Nutrition of all spider's : {Nutrition}");
            Console.WriteLine($"MovementSpeed of all spider's : {MovementSpeed} m/s");
            Console.WriteLine($"Color of all spider's : {Color}");
            Console.WriteLine($"This spider killed fly's : {killedInLifetime}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine("=========================================");
        }
        ~Arthopoda(){}
    }
}
