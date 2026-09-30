namespace RefactoringLab;

// I was learned primary ctor when I study API Course for Eng. Mohamed Elhelaly
public class OrderProcessor(IOrderRepository orderRepository, IEmailSender emailSender)
{
    private readonly IOrderRepository _orderRepository = orderRepository;
    private readonly IEmailSender _emailSender = emailSender;
    
    public void Process(int orderId, string customerEmail)
    {
        _orderRepository.Save(orderId, DateTime.Now);
        _emailSender.Send(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
    }
}

public interface IOrderRepository
{
    void Save(int orderId, DateTime processedAt);
}
public class SqlOrderRepository : IOrderRepository
{
    public void Save(int orderId, DateTime processedAt) =>
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
}

public interface IEmailSender
{
    void Send(string to, string body);
}

public class SmtpEmailSender : IEmailSender
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}
