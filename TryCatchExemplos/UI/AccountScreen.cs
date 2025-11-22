using TryCatchExemplos.Entities;
namespace TryCatchExemplos.UI;

public static class AccountScreen
{
    public static Account CreateAccountFromUserInput()
    {
        Console.WriteLine();
        Console.Write("--Write the account data--");
        Console.WriteLine();
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Holder: ");
        string holder = Console.ReadLine();
        Console.Write("Initial Balance: ");
        double amount = double.Parse(Console.ReadLine());
        Console.Write("WithDraw Limit: ");
        double withDrawLimit = double.Parse(Console.ReadLine());

        return new Account(number, holder, amount, withDrawLimit);
    }

    public static void ProcessWithDraw(Account account)
    {
        Console.WriteLine();
        Console.Write("Enter Amount to WithDraw: ");
        double withDraw = double.Parse(Console.ReadLine());
        account.WithDraw(withDraw);

        Console.WriteLine($"New balance: {account}");
    }
    
    
}