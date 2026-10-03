namespace src;

public class StudentStore
{
  private readonly List<Student> _students = new();
  public IReadOnlyList<Student> Students => _students;

  public void Add(Student student)
  {
    ArgumentNullException.ThrowIfNull(student, nameof(student));
    _students.Add(student);
  }

  public Student? GetById(int id)
  {
    foreach (var student in _students)
    {
      if (student.Id == id)
        return student;
    }
    // I can throw an exception, but I perfer to return null,
    // because I use it inside Remvoe();
    return null; 
  }

  public IReadOnlyList<Student> GetAll() => Students;
  
  public void Remove(int id)
  {
    var student = GetById(id);

    if (student is not null)
      _students.Remove(student);
  }
}