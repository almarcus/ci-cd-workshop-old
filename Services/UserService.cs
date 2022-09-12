
namespace Services;
public class UserService
{

    private static string Capitalize(string word)
    {
        return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
    }
    public static string GreetUser(string? user)
    {

        return string.IsNullOrWhiteSpace(user) ? "Who are you?" : $"Welcome, {Capitalize(user)}!";
    }
}
