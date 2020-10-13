using System;

namespace CuteAnimals
{
    public class Cat
    {
        /* Cat stats */
        private readonly string _name;
        private Hunger _hungry;
        private double _energy;
        private Moods _mood;
        private bool _alive;
        public double Energy 
        { 
            get => _energy;
            
            private set
            {
                _energy = value;
                if(_energy > 100)
                {
                    _energy = 100;
                }
                else if (_energy < 0)
                {
                    _energy = 0;
                }
            } 
        }

        public Cat(string name, Hunger hungry, double energy, Moods mood)
        {
            this._name = name;
            this._hungry = hungry;
            this._energy = energy;
            this._mood = mood;
            this._alive = true;
        }

        /* Cat actions */
        public void Meow()
        {
            Console.WriteLine("Meow Meow nigga");
        }

        public void Sleep()
        {
            Energy += 10;

            _hungry --;
            if(_hungry < Hunger.Starving)
            {
                _alive = false;
            }
            
        }

        public void Eat()
        {
            _hungry++;
            if(_hungry < Hunger.AboutToExplode)
            {
                _alive = false;
            }
        }

        public void Play()
        {
            _mood = Moods.Happy;
            Energy -= 20;
            if(Energy < 30)
            {
                _mood = Moods.Grumpy;
            }
        }
    }
}