namespace RefactoringLab;

public class AramexShippingCostCalculator : IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg) => weightKg * 12m;
}