package ch.severinkaderli.snake;

import java.awt.Graphics;
import java.util.ArrayList;
import java.util.List;

public class Game {

	/**
	 * Liste, welche alle Spielelemente enthält
	 */
	private static List<Entity> entities = new ArrayList<Entity>();
	
	/**
	 * Delegiert das zeichnen an die einzelnen Elemente
	 * @param g
	 */
	public static void draw(Graphics g) {
		entities.forEach(entity -> entity.draw(g));
	}
	
	public Game() {
		GUI gui = new GUI(this);
		//Objekte erstellen
		entities.add(new Diamond(2, 2, 5));
		entities.add(new Diamond(100, 100, 3));
		entities.add(new Snake(50, 50, 10, 40));
		
		gui.repaint();	
	}
	
	public static void main(String[] args) {
		Game game = new Game();
	}

}
