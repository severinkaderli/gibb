package ch.severinkaderli.grafik;

import java.awt.Graphics;

public class RechteckRund extends Rechteck {
    /**
     * Eckenradius des Rechtecks
     */
    public int radius;

    /**
     * @param x
     * @param y
     * @param width
     * @param height
     * @param radius
     */
    public RechteckRund(int x, int y, int width, int height, int radius) {
    	super(x, y, width, height);
    	this.radius = radius;
    }

    /* (non-Javadoc)
     * @see ch.severinkaderli.grafik.Rechteck#zeichne(java.awt.Graphics)
     */
    public void zeichne(Graphics g) {
    	//Custom code for drawing...
    }

}
