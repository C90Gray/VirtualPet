using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class MelvinMonkey
    {
        private bool isHungry;
        private int hungerLevel;
        private bool isThirsty;
        private int thirstLevel;
        private bool isTired;
        private int tiredness;
        private bool isBored;
        private int bordomLevel;

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

        public MelvinMonkey()
        {

        }

        public MelvinMonkey(int hungerLevel, int thirstLevel, int tiredness, int bordomLevel)
        {
            this.hungerLevel = hungerLevel;
            this.thirstLevel = thirstLevel;
            this.tiredness = tiredness;
            this.bordomLevel = bordomLevel;
        }
    }
}
