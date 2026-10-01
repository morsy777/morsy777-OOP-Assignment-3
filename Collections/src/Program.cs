using src;

bool exit = false;
while (!exit)
{
  Console.WriteLine("Enter a phone number:");
  var input = Console.ReadLine();
  
  if(string.IsNullOrWhiteSpace(input))
  {
    Console.WriteLine("Input cannot be null or whitespace. Please try again.");
    continue;
  }

  if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
  {
    exit = true;
    continue;
  }
  
  bool isValid = input.IsValidEgyptianPhone();
  Console.WriteLine($"Is the phone number valid? {isValid}");
}