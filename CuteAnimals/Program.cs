using System;

namespace CuteAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat chineseCat = new Cat("Tchang", Hunger.Satisfied, 20, 
                Moods.Happy);
            Cat dragonCat = new Cat("Katar", Hunger.Satisfied, 50, 
                Moods.Depressed);
            Cat foxCat = dragonCat;

            Console.WriteLine($"Cat 1 energy : {dragonCat.Energy}");
            Console.WriteLine($"Cat 2 energy : {chineseCat.Energy}");
            Console.WriteLine($"Cat 3 energy : {foxCat.Energy}");
            
        }
    }
}
