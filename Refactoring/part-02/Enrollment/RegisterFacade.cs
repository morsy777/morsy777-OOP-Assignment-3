namespace RefactoringLab.Part02.Enrollment;

// This code violates DIP beacause the RegisterFAcade depends on 
// concrete classes and it shoud depend on abstractions (interfaces)
// but for the assignment because it state that in R3 (The four services in Services.cs stay as they are)
// could u tell me in assignment's feedback if I thaught wrong.
public class RegisterFacade
{
  private readonly PaymentGateway _paymentGateway;
  private readonly SeatInventory _seatInventory;
  private readonly InvoiceGenerator _invoiceGenerator;
  private readonly EmailService _emailService;

  public RegisterFacade()
  {
    _paymentGateway = new PaymentGateway();
    _seatInventory = new SeatInventory();
    _invoiceGenerator = new InvoiceGenerator();
    _emailService = new EmailService();
  }

  public void Register(string studentId, string courseId, decimal amount)
  {
    _paymentGateway.Charge(studentId, amount);
    _seatInventory.Reserve(courseId, studentId);
    var invoiceId = _invoiceGenerator.Create(studentId, amount);
    _emailService.Send(studentId, "Enrollment confirmed", $"Invoice {invoiceId} for {courseId}");
  }
}
