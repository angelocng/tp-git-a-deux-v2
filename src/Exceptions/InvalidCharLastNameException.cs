using System;

/// <summary>
/// Exception levée lorsqu'un caractère non authorisé est rencontré
/// </summary>
public class InvalidCharLastNameException : Exception { 

	public InvalidCharLastNameException() : base("Charactère non authorisé dans le nom."){ }
	
	public InvalidCharLastNameException(string message) :base(message){ }
}
