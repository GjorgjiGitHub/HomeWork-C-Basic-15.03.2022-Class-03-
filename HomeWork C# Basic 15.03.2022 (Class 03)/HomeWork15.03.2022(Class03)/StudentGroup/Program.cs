using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////
            string[] studentsG1 = { "Andrijana Saliloska", "Menche Saliloska", "Mara Saliloska", "Ile Saliloski", "Julija Saliloska" };
            string[] studentsG2 = { "Zlatan Dimitrov", "Zaklina Dimitrova", "Marija Dimitrova", "Gjorgji Dimitrov", "Nikola Oreshkov" };

            Console.WriteLine("Choose between 1 or 2 to print students info...");
            int userChoice = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                if (userChoice == 1)
                {
                    Console.WriteLine((i + 1) + ". " + studentsG1[i]);
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine((i + 1) + ". " + studentsG2[i]);
                }
                else
                {
                    Console.WriteLine("You typed wrong number!");
                    break;
                }
            }

            Console.ReadLine();
            /////////////////////////////////////////////////////////////////////////
        }
    }
}
