/// <summary>
/// Exception de longueur de nom invalide
/// </summary>
public class InvalidLastNameLengthException : Exception
{
	/// <summary>
	/// Constructeur par d�faut
	/// </summary>
	public InvalidLastNameLengthException() : base("longueur du nom invalide, doit contenir entre 2 et 50 caract�res ") { }
	
	/// <summary>
	/// Constructeur avec message
	/// </summary>
	/// <param name="message"></param>
	public InvalidLastNameLengthException(String message) : base(message) { }
	{
	}
}