using System;

namespace _8.Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(ShouldFire(true, "bo2ss", 110));
            Console.WriteLine(ShouldFire2(true, "bo2ss", 110));
            Console.Write(ShouldFire(true, "boss", 10));
            Console.WriteLine(ShouldFire2(true, "boss", 10));
            Console.Write(ShouldFire(true, "boss", 110));
            Console.WriteLine(ShouldFire2(true, "boss", 110));
            Console.Write(ShouldFire(true, "boss", 70));
            Console.WriteLine(ShouldFire2(true, "boss", 70));
            Console.Write(ShouldFire(false, "bo2ss", 110));
            Console.WriteLine(ShouldFire2(false, "boss", 110));
        }

        static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
        {
            return enemyInFront && !(enemyName == "boss" && robotHealth < 50);
        }

        static bool ShouldFire(bool enemyInFront, string enemyName, int robotHealth)
        {
            bool shouldFire = true;
            if (enemyInFront == true)
            {
                if (enemyName == "boss")
                {
                    if (robotHealth < 50) shouldFire = false;
                    if (robotHealth > 100) shouldFire = true;
                }
            }
            else
            {
                return false;
            }
            return shouldFire;
        }
    }
}
