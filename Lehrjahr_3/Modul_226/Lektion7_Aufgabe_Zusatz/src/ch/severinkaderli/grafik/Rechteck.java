package ch.severinkaderli.grafik;

import java.awt.Graphics;

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

	public void zeichne(Graphics g) {		
		g.drawRect(x, y, width, height);
	}
}
