﻿using System;
namespace MyClassLab_number3
{
    class Program
    {
        static void Main(string[] args)
        {
            //worm...
            //Worm Worm1 = new Worm();
            //Worm1.PrintInfoWorms();
            //Worm1.FastMoving(5);
            //Worm1.PrintInfoWorms();
            //Worm1.MoveUnderEarth();
            //Worm worm2 = new Worm();
            //worm2.PrintInfoWorms();
            ////spider...
            //Arthopoda Spider1 = new Arthopoda();
            //Spider1.weaveWeb();
            //Spider1.killFly();
            //Spider1.weaveWeb();
            //Spider1.killFly();
            //Spider1.killFly();
            //Spider1.printInfo();
            ////Bear...
            //Bear Bear1 = new Bear(10);
            //Bear1.fightWithBee();
            //Bear1.fightWithBee();
            //Bear1.printInfo();
            ////Fish...
            //Fish Fish1 = new Fish();
            //Fish1.reproduction();
            //Fish1.eatGreen();
            //Fish1.reproduction();
            //Fish1.printInfo();
            //Insects InsectsSoldier = new Insects();
            //InsectsSoldier[0] = Spider1;
            //InsectsSoldier[0].killFly();
            //InsectsSoldier[0].weaveWeb();
            //^^^^^^^^^^^
            //realisation of 3rd lab

            Fish carasMisha = new Caras();
            Fish schukaDaneil = new Schuka();
            Caras carasVasya = new Caras();
            carasVasya.printInfo();
            carasVasya.eatOtherFish();
            carasVasya.getEatedFishes();

            carasMisha.swimming();
            schukaDaneil.swimming();
        }
    }
}
