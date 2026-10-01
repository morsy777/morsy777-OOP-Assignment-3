namespace src;

public static class StringValidationExtensions
{
  extension(string value)
  {
    public bool IsValidEgyptianPhone()
    {
      // violate OCP each time I need to change the country code, 
      // I have to change this method, so I will use right regex instead
      // var key = "+2";
      // if (value.StartsWith(key))
      //   value = value.Substring(key.Length); 
      
      return RegexValidator.IsValidEgyptianPhone(value);
    }
      
  }
}
