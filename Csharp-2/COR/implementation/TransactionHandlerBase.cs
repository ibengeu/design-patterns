// See https://aka.ms/new-console-template for more information
public class TransactionHandlerBase : ITransactionHandler
{
    private ITransactionHandler _handler;

    public void SetHandler(ITransactionHandler handler)
    {
        _handler = handler;
    }

    public void Handle<T>(T request)
    {
        _handler?.Handle(request);
    }
}



public interface ITransactionHandler
{
    void SetHandler(ITransactionHandler handler);
    void Handle<T>(T request);
}



