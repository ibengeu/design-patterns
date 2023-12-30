using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp
{
    // e.g., transaction flow
    /**
        Charges need to be calculated for a transaction; implement using the chain of responsibility pattern
        =================
        What we need?
        - A class which contains the details of the transaction
        - A class which contains the details of the charge 
    **/

    public class Transaction
    {
        public string? Amount { get; set; }
        public string? BankCode { get; set; }
        public string? Bank { get; set; }
        public string? AccountNo { get; set; }
        public string? Channel { get; set; }
    }

    public class TransactionCharges
    {
        public string ChargeAmount { get; set; }
    }

    public interface IChainOfResponsibility
    {
        void SetHandler(IChainOfResponsibility handler);
        void Handle<T>(T request);
    }

    public class BaseHandler : IChainOfResponsibility
    {
        private IChainOfResponsibility _handler;

        public void SetHandler(IChainOfResponsibility handler)
        {
            this._handler = handler;
        }

        public void Handle<T>(T request)
        {
            _handler.Handle(request);
        }
    }

    public class ChainOfResponsibility : BaseHandler
    {

        public void SetHandler(IChainOfResponsibility handler)
        {
            this._handler = handler;
        }

        public void Handle<T>(T request)
        {

            if(request is Transaction transaction)
            {
                Console.WriteLine("hi")
            }
            _handler.Handle(request);
        }

    }

    var main = new ChainOfResponsibility();
    main.
}
