package ch.severinkaderli.grafik;

import java.awt.Graphics;

public class Kreis extends Figur {
	private int radius;
	
	public Kreis(int x, int y, int radius) {
		super(x, y);
		this.radius = radius;
	}
	
	public int getRadius() {
		return radius;
	}
	
	public void zeichne(Graphics g) {
		g.drawOval(x-radius, y-radius, radius*2, radius*2);
	}
}
