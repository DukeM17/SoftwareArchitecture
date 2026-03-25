namespace SoftwareArchitecture.Design_Patterns.Creational_Patterns.Factory
{
    public static class PaymentProcessorFactory
    {
        public static IPaymentProcessor Create(string type) => type switch
        {
            "creditcard" => new CreditCardPaymentProcessor(),
            "paypal" => new PayPalPaymentProcessor(),
            "crypto" => new CryptoPaymentProcessor(),
            _ => throw new ArgumentException($"Payment type {type} unknown")
        };
    }
}
