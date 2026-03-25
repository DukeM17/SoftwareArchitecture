namespace SoftwareArchitecture.Design_Patterns.Creational_Patterns.Factory
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing £{amount} via PayPal");
        }
    }

    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing £{amount} via Credit Card");
        }
    }

    public class CryptoPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing £{amount} via Crypto");
        }
    }
}
