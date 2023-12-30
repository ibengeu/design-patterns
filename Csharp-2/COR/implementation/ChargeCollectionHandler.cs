// See https://aka.ms/new-console-template for more information
public class ChargeCollectionHandler : TransactionHandlerBase
{
    public void Handle<T>(T request)
    {
        if (request is Transaction transaction)
        {
            Console.WriteLine("Handling Charge Collection");
            // Additional logic for handling charges...
        }
        else
        {
            //base.Handle<T>(request);
            // The base class's Handle method will be called automatically.
        }
    }
}


