namespace TryCatchExemplos.Entities.Exceptions;

public class DomainException : Exception
{
    public DomainException(string message) : base(message)
    {
        
    }

    public DomainException() { }

    public DomainException(string message, Exception originalError) : base(message, originalError) {}
    
    
}