package figuren;

public class Figur {
	protected int x;
	protected int y;
	
	public Figur(int x, int y) {
		this.x = x;
		this.y = y;
	}
	
	public void move(int dx, int dy) {
		x += dx;
		y += dy;
	}
}
