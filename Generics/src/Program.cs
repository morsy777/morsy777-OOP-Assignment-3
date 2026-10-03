using src;

# region Student smoke test
var store = new Store<Student>();
//store.Add(new Student(1001, ""));
//store.Add(new Student(-1, "Ahmed"));

store.Add(new Student(1, "Morsi"));
store.Add(new Student(2, "Ali"));
store.Add(new Student(3, "Eslam"));
store.Add(new Student(4, "Sara"));
store.Add(new Student(5, "Rasha"));

//store.Add(new Student(1, "Mohamed"));

var storeStudent = store.GetById(1);
Console.WriteLine($"Id: {storeStudent?.Id}, Name: {storeStudent?.Name}\n"); // ? for null saftey

foreach (var s in store.GetAll())
  Console.WriteLine($"Id: {s.Key}, Name: {s.Value.Name}");

Console.WriteLine();

store.Remove(1);

foreach (var s in store.GetAll())
  Console.WriteLine($"Id: {s.Key}, Name: {s.Value.Name}");

Console.WriteLine();
#endregion

#region Enumerable Extensions 

// IEnumerable<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// nums = nums.Page(2, 2); // pageNumber = 2, pageSize = 2

// foreach (var num in nums)
//   Console.WriteLine(num);

IEnumerable<Student> students = new List<Student>
{
  new Student(1, "Morsi"),
  new Student(2, "Ali"),
  new Student(3, "Eslam"),
  new Student(4, "Sara"),
  new Student(5, "Rasha"),
  new Student(6, "Mohamed"),
  new Student(7, "Ahmed")
};

var pagedStudents = students.Page(2, 2); // pageNumber = 2, pageSize = 2

foreach (var student in pagedStudents)
  Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
Console.WriteLine();

var studentById = students.FindById(3);
Console.WriteLine($"Id: {studentById?.Id}, Name: {studentById?.Name}\n");
Console.WriteLine();

// var s = new Store<string>();
#endregion