namespace RefactoringLab;

public class DHLShippingCostCalculator : IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg) => weightKg * 18m;
}