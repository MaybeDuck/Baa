using System;

namespace Day1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Type a number");

           string userInput = Console.ReadLine();
            int.TryParse(userInput, out int userNumber);
           
            Random random = new Random();
            //Console.WriteLine(random.Next(1, 2));
            for (int i = 0; i < userNumber; i++)
            {
                if (random.Next(1, 2) == 1)
                {
                    Console.WriteLine("Baa");
                }
                if (random.Next(1, 3) == 2)
                {

                    Console.Write(i + " Sheep\n");
                }


            }
        }

    }
}
