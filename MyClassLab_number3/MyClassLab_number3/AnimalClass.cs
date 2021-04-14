using System;
namespace MyClassLab_number3
{
    enum color
    {
        Red,
        Green,
        White,
        Orange,
        Blue,
        Brown,
        Yellow
    }
    abstract class AnimalClass
    {
        public AnimalClass(){}
        public color Color;
        public string Habitat;
        public string Nutrition;
        public int MovementSpeed;
        ~AnimalClass(){}
    }
}
