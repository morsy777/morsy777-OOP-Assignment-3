namespace src;

public class Student
{
  public int Id { get;}
  public string Name { get; private set; }

  public Student(int id, string name)
  {
    ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id, nameof(id));
    ArgumentException.ThrowIfNullOrEmpty(name, nameof(name));
    
    Id = id;
    Name = name;
  }
}