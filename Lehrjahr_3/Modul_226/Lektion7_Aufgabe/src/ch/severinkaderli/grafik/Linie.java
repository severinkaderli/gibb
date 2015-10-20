package ch.severinkaderli.grafik;

import java.awt.Graphics;

public class Linie extends Figur {

	private int x2;
	private int y2;
	
	public Linie(int x, int y, int x2, int y2) {
		super(x, y);
		this.x2 = x2;
		this.y2 = y2;
	}

	public void move(int dx, int dy) {
		x += dx;
		y += dy;
	}

	public void zeichne(Graphics g) {
		g.drawLine(this.x, this.y, this.x2, this.y2);
	}
}
