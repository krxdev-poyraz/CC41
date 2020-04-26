using System;

namespace CC41
{
    class Program
    {
        static void Main(string[] args)
        {
            int healthHero = 200;
            int numberVillians = 5;
            int[] villianHealth = { 54 , 23 , 65 , 87 , 12 };

            Array.Sort(villianHealth);

            int deadVillian = 0;
            for (int i = 0 ; i < numberVillians ; i++)
            {
                healthHero -= villianHealth[i];
                if(healthHero<=0) break;
                else deadVillian++;
            }

            Console.WriteLine(deadVillian);
            Console.ReadLine();
        }
    }
}