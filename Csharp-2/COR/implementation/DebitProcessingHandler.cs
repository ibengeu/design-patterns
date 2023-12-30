// See https://aka.ms/new-console-template for more information
public class DebitProcessingHandler : TransactionHandlerBase
{
    public void Handle<T>(T request)
    {
        if (request is Transaction transaction)
        {
            Console.WriteLine("Processing Debit Transaction");
            // Additional logic for processing debit...
        }
        else
        {
            // The base class's Handle method will be called automatically.
        }
    }
}


