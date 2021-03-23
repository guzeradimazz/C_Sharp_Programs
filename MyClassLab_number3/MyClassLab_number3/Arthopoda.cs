using System;
using System.Collections.Generic;
namespace MyClassLab_number3
{
    class Insects
    {
        private List<Arthopoda> InsectsArmy = new List<Arthopoda>();
        public Arthopoda this[int index]
        {
            get
            {
                if (index < 0 && index >= InsectsArmy.Count)
                {
                    throw new Exception("There is no arthopoda with such index\n");
                }
                return InsectsArmy[index];
            }
            set
            {
                InsectsArmy.Add(value);
            }
        }
    }
    class Arthopoda : AnimalClass
    {
        Insects[] ArthopodaArray;
        public Arthopoda(int killedFly)
        {
            ArthopodaArray = new Insects[50];
            this.killedFly = killedFly;
            killedInLifetime = killedFly; 
            Habitat = "Trees";
            Nutrition = "Insects";
            MovementSpeed = 5;
            Color = color.White;
        }
        public Arthopoda()
        {
            ArthopodaArray = new Insects[50];
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
