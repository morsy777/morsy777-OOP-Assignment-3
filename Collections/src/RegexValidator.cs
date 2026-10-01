using System.Text.RegularExpressions;

namespace src;

// resource: https://regex101.com/r/yGJGyR/1
public class RegexValidator
{
    public static bool IsValidEgyptianPhone(string value)
    {
        var egyptianPhoneRegex = new Regex(@"^(01[125]\d{8}|\+201[125]\d{8})$");
        return egyptianPhoneRegex.IsMatch(value);
    }
}