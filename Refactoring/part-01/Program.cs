using RefactoringLab;

// var shipping = new ShippingCostCalculator();
// Console.WriteLine($"Aramex 2kg → {shipping.Calculate("Aramex", 2)}");
// Console.WriteLine($"FedEx 2kg  → {shipping.Calculate("FedEx", 2)}");
// Console.WriteLine();

IShippingCostCalculatorFactory shippingFactory = new AramexShippingCostCalculatorFactory();
var shippingCalculator = shippingFactory.Create();
var shippingCost = shippingCalculator.Calculate(2);
Console.WriteLine($"Aramex 2kg → {shippingCost}");

shippingFactory = new FedExShippingCostCalculatorFactory();
shippingCalculator = shippingFactory.Create();
shippingCost = shippingCalculator.Calculate(2);
Console.WriteLine($"FedEx 2kg → {shippingCost}");

Console.WriteLine();

var processor = new OrderProcessor(new SqlOrderRepository(), new SmtpEmailSender());
processor.Process(1001, "customer@example.com");
Console.WriteLine();

new UrgentScheduledEmailNotification { SendAt = DateTime.Today.AddHours(18) }
    .Send("customer@example.com", "Your order ships tomorrow");
new UrgentSmsNotification()
    .Send("+201000000000", "OTP 4821");
