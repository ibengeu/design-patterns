using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp
{
    // eg. transaction flow
    /**
        Charges neeed to be taken for a transaction, implement using the chain of responsibility pattern
        =================
        what we need?
        - a class which contains the details of the transaction
        - a class which contains the details of the charge 
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


    interface IChainOfResponsibility
    {
        void setHandler();
        void handle();
    }

    public abstract class BaseHandler : IChainOfResponsibility
    {

        
        public abstract void handle(BaseHandler handler)
        

    }

    public class ChainOfResponsibility : BaseHandler
    {

    }
}