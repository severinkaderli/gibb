package ch.severinkaderli.grafik;

import java.awt.Graphics;

public class RechteckRund extends Rechteck {
    public int radius;

    public RechteckRund(int x, int y, int width, int height, int radius) {
    	super(x, y, width, height);
    	this.radius = radius;
    }

    public void zeichne(Graphics g) {
    	//Custom code for drawing...
    }

}
