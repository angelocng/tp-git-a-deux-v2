using System.Security.AccessControl;
using System.Text.RegularExpressions;
/// <summary>
/// Classe utilisé pour verifier les chaines de caractères
/// </summary>
public static class CheckString
{

    /// <summary>
    /// Vérifie la longueur d'une chaine de caractère
    /// </summary>
    /// <exception cref="InvalidStringLengthException"></exception>
    public static void CheckLastNameLength(string _toCheck)
    {
        if (_toCheck.Length < 2 && _toCheck.Length > 50)
        {
            throw new InvalidStringLengthException();
        }
    }

    /// <summary>
    /// Verifie le format du nom 
    /// </summary>
    /// <param name="_toCheck"></param>
    /// <exception cref="InvalidCharException"></exception>
    public static void CheckLastNameFormat(string _toCheck)
    {
        if (!Regex.IsMatch(_toCheck, @"^[\p{L}{2,}(?:[-\s]{0,1}\p{L}{2,}){0,}$")
        {
            throw new InvalidCharException();
        }
    }


}


    