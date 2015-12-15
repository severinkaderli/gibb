public class Calculator {

	private enum Operation {
		ADDITION, SUBTRACTION, MULTIPLICATION, DIVISION
	}

	public static void calculate(int x, int y, Operation operation)
			throws NegativeNumberException {
		if (x <= 0 || y <= 0) {
			throw new NegativeNumberException(
					"Es können keine negativen Zahlen oder 0 zum Rechnen verwendet werden!");
		}
		switch (operation) {
		case ADDITION:
			System.out.println(x + y);
			break;
		case SUBTRACTION:
			System.out.println(x - y);
			break;
		case MULTIPLICATION:
			System.out.println(x * y);
			break;
		case DIVISION:
			System.out.println(x / y);
			break;
		default:
			System.out.println("Ungültiger Operator!");
			break;
		}
	}

	public static void main(String[] args) {
		try {
			calculate(2, 3, Operation.ADDITION);
			calculate(-2, 3, Operation.DIVISION);
			calculate(4, 3, Operation.MULTIPLICATION);
		} catch (NegativeNumberException ex) {
			System.out.println(ex.getMessage());
		} finally {
			System.out.println("Der Code im Finally-Block wird immer ausgeführt!");
		}

	}
}
