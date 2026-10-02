using src;

// Smoke test
var store = new Store<Student>();
//store.Add(new Student(1001, ""));
//store.Add(new Student(-1, "Ahmed"));

store.Add(new Student(1, "Morsi"));
store.Add(new Student(2, "Ali"));
store.Add(new Student(3, "Eslam"));
store.Add(new Student(4, "Sara"));

//store.Add(new Student(1, "Mohamed"));

var student = store.GetById(1);
Console.WriteLine($"Id: {student?.Id}, Name: {student?.Name}\n"); // ? for null saftey

foreach (var s in store.GetAll())
  Console.WriteLine($"Id: {s.Key}, Name: {s.Value.Name}");

Console.WriteLine();

store.Remove(1);

foreach (var s in store.GetAll())
  Console.WriteLine($"Id: {s.Key}, Name: {s.Value.Name}");
