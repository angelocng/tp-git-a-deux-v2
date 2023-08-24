using System.Text.RegularExpressions;
namespace src.Tools
{
    public class Control
    {
        public static bool ControlFirstNameUser(string firstNameUser)
        {
            return Regex.Match(firstNameUser, @"^[\p{L}\-]{1,40}$").Success;
        }
    }
}