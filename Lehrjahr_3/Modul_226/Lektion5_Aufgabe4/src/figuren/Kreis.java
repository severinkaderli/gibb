package figuren;

public class Kreis extends Figur {
	private int radius;
	
	public Kreis(int x, int y, int radius) {
		super(x, y);
		this.radius = radius;
	}
	
	public int getRadius() {
		return radius;
	}
}
