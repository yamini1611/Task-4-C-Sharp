using System;

namespace Task_4
{
    struct Trainee
    {
        public string name;
        public bool isPresent;
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of trainees");
            int count = Convert.ToInt32(Console.ReadLine());
            Trainee[] trainee = new Trainee[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter name of trainee {i + 1}");
                trainee[i].name = Console.ReadLine();

                Console.WriteLine($"Is {trainee[i].name} Present? (Yes / No):");
                string input = Console.ReadLine();
                trainee[i].isPresent = input.ToLower() == "yes";
            }

            int presentCount = 0;
            int absentCount = 0;

            foreach (var i in trainee)
            {
                if (i.isPresent)
                {
                    Console.WriteLine("Trainee Present: ");
                    Console.WriteLine($"{i.name}");
                    presentCount++;
                }
                else
                {
                    Console.WriteLine("Trainee Absent: ");
                    Console.WriteLine($"{i.name}");
                    absentCount++;
                }
            }

            Console.WriteLine("Attendance History");
            Console.WriteLine($"Total Present: {presentCount}");
            Console.WriteLine($"Total Absent: {absentCount}");
            Console.ReadLine();
        }
    }
}
