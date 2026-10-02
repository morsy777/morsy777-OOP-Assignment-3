namespace src;

public class CourseStore
{
  private readonly List<Course> _courses = new();
  public IReadOnlyList<Course> Courses => _courses;

  public void Add(Course course)
  {
    ArgumentNullException.ThrowIfNull(course, nameof(course));
    _courses.Add(course);
  }

  public Course? GetById(int id)
  {
    foreach (var course in _courses)
    {
      if (course.Id == id)
        return course;
    }
    return null;
  }

  public IReadOnlyList<Course> GetAll() => Courses;

  public void Remove(int id)
  {
    var course = GetById(id);

    if (course is not null)
      _courses.Remove(course);
  }
}
