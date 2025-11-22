using TryCatchExemplos.Entities;
using TryCatchExemplos.Entities.Exceptions;
using TryCatchExemplos.UI;

namespace TryCatchExemplos;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Account account = AccountScreen.CreateAccountFromUserInput();

            AccountScreen.ProcessWithDraw(account);
        }
        catch (DomainException e)
        {
            Console.WriteLine("Error in Account Operation " + e);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error. " + ex);
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected error" + e);
        }
        
    }
}