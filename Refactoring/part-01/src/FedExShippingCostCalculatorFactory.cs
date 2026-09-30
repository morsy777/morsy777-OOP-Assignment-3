namespace RefactoringLab;

public class FedExShippingCostCalculatorFactory : IShippingCostCalculatorFactory
{
    public IShippingCostCalculator Create() => new FedExShippingCostCalculator();
}