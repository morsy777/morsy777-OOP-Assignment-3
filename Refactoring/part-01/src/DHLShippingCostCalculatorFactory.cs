namespace RefactoringLab;

public class DHLShippingCostCalculatorFactory : IShippingCostCalculatorFactory
{
    public IShippingCostCalculator Create() => new DHLShippingCostCalculator();
}