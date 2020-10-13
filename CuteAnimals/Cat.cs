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
        public double Energy => _energy;

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
        
            _energy += 20; 
            if(_energy > 100)
            {
                _energy = 100;
            }

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
            _energy -= 20;
            if(_energy < 30)
            {
                _mood = Moods.Grumpy;
            }
        }
    }
}