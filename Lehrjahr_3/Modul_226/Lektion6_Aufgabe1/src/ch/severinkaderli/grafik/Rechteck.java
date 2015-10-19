package ch.severinkaderli.grafik;

public class Rechteck extends Figur {

	private int width;
	private int height;
	
	public Rechteck(int x, int y, int width, int height) {
		super(x, y);
		this.width = width;
		this.height = height;
	}
	
	public int getWidth() {
		return width;
	}
	
	public int getHeight() {
		return height;
	}
	
}
