using System.Text.RegularExpressions;
namespace src.Tools
{
    public class Control
    {
        public static bool ControlLastNameUser(string LastnameUser)
        {
            return Regex.Match(LastnameUser, @"^[\p{L}\-]{1,40}$").Success;
        }
    }
}