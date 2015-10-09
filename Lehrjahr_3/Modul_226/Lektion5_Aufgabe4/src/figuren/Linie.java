package figuren;

public class Linie extends Figur {
	private int length;
	private int angle;
	
	public Linie(int x, int y, int length, int angle) {
		super(x, y);
		this.length = length;
		this.angle = angle;
	}
	
	public void move(int dx, int dy) {
		x += 2*dx;
		y += 2*dy;
	}
	
	public int getLength() {
		return length;
	}
	
	public int getAngle() {
		return angle;
	}
}
