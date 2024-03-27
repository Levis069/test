using System;

namespace git_test_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot!: ");
            int felhasznaloSzam = int.Parse(Console.ReadLine());
            for (int i = 0; i <= felhasznaloSzam; i++)
            {
                if (i == felhasznaloSzam)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}
