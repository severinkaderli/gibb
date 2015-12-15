/**
 * Custom exception that gets thrown when a negative number is used
 * 
 * @author Severin Kaderli
 */
public class NegativeNumberException extends Exception {
	// Parameterless Constructor
	public NegativeNumberException() {
	}

	// Constructor that accepts a message
	public NegativeNumberException(String message) {
		super(message);
	}

}
