using System;

namespace Car_Insurance_Approval
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had DUIs? Please answer with \"True\" or \"False\" only.");
            bool duis = bool.Parse(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool qualifications = (age > 15) && (!duis) && (tickets <= 3);
            Console.WriteLine("Qualified: " + qualifications);


            Console.Read();
        }
    }
}
