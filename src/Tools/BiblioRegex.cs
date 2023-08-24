using System.Text.RegularExpressions;
namespace src.Tools
{
    public class Control
    {
        public static bool ControlNameUser(string nameUser)
        {
            return Regex.Match(nameUser, @"^[\p{L}\-]{1,40}$").Success;
        }
    }
}