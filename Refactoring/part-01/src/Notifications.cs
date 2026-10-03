namespace RefactoringLab;

public interface INotification
{
  void Send(string to, string message);
}

public class EmailNotification : INotification
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[email] {to}: {message}");
}

public class SmsNotification : INotification
{
  public void Send(string to, string message) =>
      Console.WriteLine($"[sms] {to}: {message}");
}

public class UrgentEmailNotification
{
	private readonly INotification _notification;
	public UrgentEmailNotification()
	{
		_notification = new EmailNotification();
	}

	public void Send(string to, string message) =>
		_notification.Send(to, $"[URGENT] {message}");
}

public class UrgentSmsNotification
{
	private readonly INotification _notification;
	public UrgentSmsNotification()
	{
		_notification = new SmsNotification();
	}

  public void Send(string to, string message) =>
      _notification.Send(to, $"[URGENT] {message}");
}

public class UrgentScheduledEmailNotification : INotification
{
    public DateTime SendAt { get; set; }

    public void Send(string to, string message) =>
        Console.WriteLine($"[email scheduled {SendAt:g}] {to}: [URGENT] {message}");
}

public class UrgentScheduledSmsNotification : INotification
{
    public DateTime SendAt { get; set; }

    public void Send(string to, string message) =>
        Console.WriteLine($"[sms scheduled {SendAt:g}] {to}: [URGENT] {message}");
}
