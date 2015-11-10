package ch.severinkaderli.snake;

import java.awt.Graphics;
import java.awt.Rectangle;

public abstract class Entity {
    protected boolean isAlive;

    protected Rectangle position;

    /**
     * Creates the element at the specified position with
     * the specified height and width
     * 
     * @param x
     * @param y
     * @param width
     * @param height
     */
    public Entity(int x, int y, int width, int height) {
    	this.position = new Rectangle(x, y, width, height);
    }

    public abstract void draw(Graphics g);
}
