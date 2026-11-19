using PaymentProcessor;

List<IPayment> payments = new()
{
    new CreditCardPayment(),
    new PayPalPayment(),
    new CashPayment()
};

foreach (var payment in payments)
{
    payment.Pay(100m);
}