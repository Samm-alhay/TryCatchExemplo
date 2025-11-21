using TryCatchExemplos.Entities.Exceptions;
namespace TryCatchExemplos.Entities;

public class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    private double Balance { get; set; }
    private double WithDrawLimit { get; set; }


    public Account(int number, string holder, double balance, double withDrawLimit)
    {
        Number = number;
        Holder = holder;
        Deposit(balance);
        WithDrawLimit = withDrawLimit;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new DomainException("The amount must be a number superior to 0");
        }
        
        Balance += amount;
    }

    public void WithDraw(double amount)
    {
        if (Balance < amount)
        {
            throw new DomainException("You dont have enough Balance to withdraw this amount, Current Balance: " + Balance);
        }

        if (amount > WithDrawLimit)
        {
            throw new DomainException("Your withDraw Limit is inferior than the amount to withdraw, Current WithDrawLimit: " + WithDrawLimit);
        }
        
        Balance -= amount;
    }

    public override string ToString()
    {
        return "Account number: "
               + Number
               + "Holder: "
               + Holder
               + "Balance: "
               + Balance;
    }
}