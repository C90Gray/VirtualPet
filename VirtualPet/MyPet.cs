using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class MyPet
    {
        private bool isHungry;
        private int hungerLevel;
        private bool isThirsty;
        private int thirstLevel;
        private bool isTired;
        private int tiredness;
        private bool isBored;
        private int bordomLevel;
        private bool hasToPotty;

        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }
        
        public int HungerLevel
        {
            get { return this.hungerLevel; }
            set { this.hungerLevel = value; }
        }

        public bool IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
        }

        public int ThirstLevel
        {
            get { return this.thirstLevel; }
            set { this.thirstLevel = value; }
        }

        public bool IsTired
        {
            get { return this.isTired; }
            set { this.isTired = value; }
        }
        
        public int Tiredness
        {
            get { return this.tiredness; }
            set { this.tiredness = value; }
        }

        public bool IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
        }

        public int BordomLevel
        {
            get { return this.bordomLevel; }
            set { this.bordomLevel = value; }
        }

        public bool HasToPotty
        {
            get { return this.hasToPotty; }
            set { this.hasToPotty = value; }
        }

        public MyPet()
        {

        }


        public MyPet(int hungerLevel, int thirstLevel, int tiredness, int bordomLevel)
        {
            this.hungerLevel = hungerLevel;
            this.thirstLevel = thirstLevel;
            this.tiredness = tiredness;
            this.bordomLevel = bordomLevel;
        }

        public string FeedMe()
        {
            if (hungerLevel > 50)
            {
                IsHungry = false;
                hungerLevel -= 10;
                return "has been fed. \n";
            }
            else
            {
                hasToPotty = true;
                return "isn't hungry. \n";
            }
        }

        public string Drink()
        {
            if (thirstLevel > 50)
            {
                isThirsty = false;
                hasToPotty = true;
                thirstLevel = 0;
                return "'s thirst was quenched. \n";
            }
            else
            {
                return "isn't thirsty right now.";
            }
        }

        public void Play()
        {
            bordomLevel -= 25;
            hungerLevel += 15;
            thirstLevel += 25;
        }

        public void Sleep()
        {
            if (tiredness > 25)
            {
                bordomLevel += 10;
                hungerLevel += 20;
                thirstLevel += 10;
                tiredness = 0;
            }
            else
            {
                Console.WriteLine("He isn't tired right now");
            }
        }

        public void Potty()
        {
            hungerLevel += 15;
            thirstLevel += 10;
        }

        public void Tick()
        {
            Random r = new Random();

            hungerLevel = hungerLevel + r.Next(-10, 10);
            thirstLevel = thirstLevel + r.Next(-3, 3);
            tiredness = tiredness + r.Next(-30, 30);
            bordomLevel = bordomLevel = r.Next(-15, 15);
            if (hungerLevel > 50)
            {
                isHungry = true;
            }
            else
            {
                isHungry = false;
                hasToPotty = true
            }

            if (thirstLevel > 50)
            {
                isThirsty = true;
            }
            else
            {
                isThirsty = false;
                hasToPotty = true;
            }

            if (bordomLevel > 50)
            {
                isBored = true;
            }
            else
            {
                isBored = false;
            }

            if (tiredness > 50)
            {
                isTired = true;
            }
            else
            {
                isTired = false;
            }

            Console.WriteLine("It is " + isHungry + " that your pet is hungry. \nHunger Level: " + hungerLevel);
            Console.WriteLine("It is " + IsThirsty + " that your pet is thirsty. \nThirst Level: " + thirstLevel);
            Console.WriteLine("It is " + isTired + " that your pet is tired. \nTiredness: " + tiredness);
            Console.WriteLine("It is " + isBored + " that your pet is bored. \nBordom Level: " + bordomLevel);
            Console.WriteLine("It is " + hasToPotty + " that your pet has to go potty.");
        }
    }
}
