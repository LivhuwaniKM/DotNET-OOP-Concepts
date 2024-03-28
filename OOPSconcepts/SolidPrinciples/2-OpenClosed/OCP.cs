namespace OOPSconcepts.SolidPrinciples._2_OCP
{
    // Open/Closed Responsibility
    public class OCP
    {
        public string Main()
        {
            CreditCardPayment creditCard = new();
            var credit = creditCard.ProcessPayment(10200);

            PayPalPayment payPal = new();
            var pal = payPal.ProcessPayment(13000);

            CryptoCurrencyPayment cryptoCurrency = new();
            var crypto = cryptoCurrency.ProcessPayment(16000);

            string output = "Open/Closed Responsibility\n===========================================\n";
            output += credit + "\n";
            output += pal + "\n";
            output += crypto;

            return output;
        }
    }

    public class PaymentProcessor
    {
        public void ProcessPayment(IPaymentMethod paymentMethod, decimal amount)
        {
            paymentMethod.ProcessPayment(amount);
        }
    }

    public interface IPaymentMethod
    {
        string ProcessPayment(decimal amount);
    }

    public class CreditCardPayment : IPaymentMethod
    {
        public string ProcessPayment(decimal amount)
        {
            return $"Processing credit card payment for {amount}";
        }
    }

    public class PayPalPayment : IPaymentMethod
    {
        public string ProcessPayment(decimal amount)
        {
            return $"Processing PayPal payment for {amount}";
        }
    }

    public class CryptoCurrencyPayment : IPaymentMethod
    {
        public string ProcessPayment(decimal amount)
        {
            return $"Processing CryptoCurrency payment for {amount}";
        }
    }
}