using System;
/**
 *  ## Example of transaction flow using the Chain of Responsibility pattern
    Charges need to be calculated for a transaction; implement using the chain of responsibility pattern
    =================
    What we need?
    - A class that contains the details of the transaction
    - A class that contains the details of the charge 
**/

var chargeHandler = new ChargeCollectionHandler();
var debitHandler = new DebitProcessingHandler();

chargeHandler.SetHandler(debitHandler);

// Create a sample transaction
var sampleTransaction = new Transaction
{
    Amount = "100",
    BankCode = "123",
    Bank = "Sample Bank",
    AccountNo = "987654",
    Channel = "Online"
};

chargeHandler.Handle(sampleTransaction);



