//2. Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.
//Use the format specifiers to display currency, % symbol.

namespace Assignment2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in the amount of your bill:  ");
            double bill = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type tip percentage to give (provide in whole numbers): ");
            double percentage = Convert.ToDouble(Console.ReadLine());
            double convertPercentage = percentage * .01;         
            double tipAmount = bill * convertPercentage;           
            double totalAmount = bill + tipAmount;
           

            Console.WriteLine("Break down of your bill total is below: ");
            Console.WriteLine($"Bill amount: ${bill} ");
            Console.WriteLine($"Tip pecentage choosen: {percentage}%");
            Console.WriteLine($"Total bill is: ${totalAmount}");
            Console.WriteLine();
            Console.WriteLine("Thank you!");

           





        }
    }
}
