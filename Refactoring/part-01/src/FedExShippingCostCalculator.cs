namespace RefactoringLab;

public class FedExShippingCostCalculator : IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg) => weightKg * 15m;
}