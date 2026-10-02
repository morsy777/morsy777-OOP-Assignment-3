namespace src;

public class Course : IHasId
{
  public int Id { get; }
  public string Title { get; private set; }
  public decimal Price { get; private set; }

  public Course(int id, string title, decimal price)
  {
    ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id, nameof(id));
    ArgumentException.ThrowIfNullOrEmpty(title, nameof(title));
    ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price, nameof(price));

    Id = id;
    Title = title;
    Price = price;
  }
}
