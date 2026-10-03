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