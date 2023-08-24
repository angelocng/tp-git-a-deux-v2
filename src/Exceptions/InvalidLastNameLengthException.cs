/// <summary>
/// Exception de longueur de nom invalide
/// </summary>
public class InvalidLastNameLengthException : Exception
{
	/// <summary>
	/// Constructeur par défaut
	/// </summary>
	public InvalidLastNameLengthException() : base("longueur du nom invalide, doit contenir entre 2 et 50 caractères ") { }
	
	/// <summary>
	/// Constructeur avec message
	/// </summary>
	/// <param name="message"></param>
	public InvalidLastNameLengthException(String message) : base(message) { }
	{
	}
}