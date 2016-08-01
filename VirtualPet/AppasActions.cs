using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class AppasActions
    {
        //Fields
        private int hunger;
        private int thirst;
        private int play;
        private int attack;
        private int pts;
        private string name;

        //Properties

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        
        public int Play
        {
            get { return this.play; }
            set { this.play = value; }
        }

        public int Attack
        {
            get { return this.attack; }
            set { this.attack = value; }
        }

        public int PTS
        {
            get { return this.pts; }
            set { this.pts = value; }
        }
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }      

        //Constructor 
        public AppasActions()
        {
            this.hunger = 100;
            this.thirst = 100;
            this.play = 100;
            this.attack = 100;
            this.pts = 100;
            this.name = "Aang";            

        }
        //Methods
        public void Eat()// Increase points if option is selected for hunger
        {
            hunger = hunger + 10;
        }
        public void DontEat()// Decreases points if option is selected for hunger
        {
            hunger = hunger - 10;
        }
        public void Drink()
        {
            thirst = thirst + 10;
        }
        public void DontDrink()
        {
            thirst = thirst - 10;
        }
        public void Fly()
        {
            play = play + 10;
        }
        public void DontFly()
        {
            play = play - 10;
        }
        public void Fight()
        {
            attack = attack + 10;
        }
        public void DontFight()
        {
            attack = attack - 10;
        }
        public void StatLevels()
        {
            Console.WriteLine("\nHunger:" + this.hunger);
            Console.WriteLine("Thirst:" + this.thirst);
            Console.WriteLine("Health:" + this.play);
            Console.WriteLine("Strength:" + this.attack);
        }
        public void Tick() // Tick method sets value
        {
            pts = pts - 10;
            hunger = hunger + 20;
        }

    }
}
