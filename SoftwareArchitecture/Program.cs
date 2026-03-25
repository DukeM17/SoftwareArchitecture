using SoftwareArchitecture.Design_Patterns.Creational_Patterns.Factory;

var paymentProcessor = PaymentProcessorFactory.Create("creditcard");
paymentProcessor.ProcessPayment(20.20m);