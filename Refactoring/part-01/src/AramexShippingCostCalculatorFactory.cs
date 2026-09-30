namespace RefactoringLab;

public class AramexShippingCostCalculatorFactory : IShippingCostCalculatorFactory
{
    public IShippingCostCalculator Create() => new AramexShippingCostCalculator();
}