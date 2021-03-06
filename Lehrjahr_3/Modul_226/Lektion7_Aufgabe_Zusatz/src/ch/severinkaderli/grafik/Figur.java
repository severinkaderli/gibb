package ch.severinkaderli.grafik;

import java.awt.Graphics;

abstract public class Figur {
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

	abstract public void zeichne(Graphics g);

}
