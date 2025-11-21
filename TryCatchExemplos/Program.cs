using TryCatchExemplos.Entities;
using TryCatchExemplos.Entities.Exceptions;

namespace TryCatchExemplos;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter Account Data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double amount = double.Parse(Console.ReadLine());
            Console.Write("WithDraw Limit: ");
            double withDrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, amount, withDrawLimit);


            Console.Write("Enter Amount to WithDraw: ");
            double withDraw = double.Parse(Console.ReadLine());
            account.WithDraw(withDraw);

        }
        catch (DomainException e)
        {
            Console.WriteLine("Error. " + e.Message);
        }
        
        
    }
}