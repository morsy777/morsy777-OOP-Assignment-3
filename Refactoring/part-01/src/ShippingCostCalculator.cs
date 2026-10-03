namespace RefactoringLab;

public class ShippingCostCalculator
{
    public decimal Calculate(string carrier, decimal weightKg)
    {
        switch (carrier)
        {
            case "Aramex":
                return weightKg * 12m;
            case "FedEx":
                return weightKg * 15m;
            case "DHL":
                return weightKg * 18m;
            default:
                throw new ArgumentException($"Unknown carrier: {carrier}");
        }
    }
}

// public interface IShippingCostCalculator
// {
//     decimal Calculate(decimal weightKg);
// }

// public class AramexShippingCostCalculator : IShippingCostCalculator
// {
//     public decimal Calculate(decimal weightKg) => weightKg * 12m;
// }

// public class FedExShippingCostCalculator : IShippingCostCalculator
// {
//     public decimal Calculate(decimal weightKg) => weightKg * 15m;
// }

// public class DHLShippingCostCalculator : IShippingCostCalculator
// {
//     public decimal Calculate(decimal weightKg) => weightKg * 18m;
// }

// public interface IShippingCostCalculatorFactory
// {
//     IShippingCostCalculator Create();
// }

// public class AramexShippingCostCalculatorFactory : IShippingCostCalculatorFactory
// {
//     public IShippingCostCalculator Create() => new AramexShippingCostCalculator();
// }

// public class FedExShippingCostCalculatorFactory : IShippingCostCalculatorFactory
// {
//     public IShippingCostCalculator Create() => new FedExShippingCostCalculator();
// }

// public class DHLShippingCostCalculatorFactory : IShippingCostCalculatorFactory
// {
//     public IShippingCostCalculator Create() => new DHLShippingCostCalculator();
// }
