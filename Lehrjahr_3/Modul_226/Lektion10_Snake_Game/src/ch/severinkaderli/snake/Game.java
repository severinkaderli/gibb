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
	 * Anzahl der Diamante, die auf dem Feld erschienen sollen.
	 */
	private int numberOfDiamonds = 10;
	
	/**
	 * Delegiert das zeichnen an die einzelnen Elemente
	 * @param g
	 */
	public static void draw(Graphics g) {
		entities.forEach(entity -> entity.draw(g));
	}
	
	/**
	 * Erstellt die Elemente, die für das Spiel nötig sind und zeigt am
	 * Schluss das Feld an.
	 */
	public Game() {
		GUI gui = new GUI(this);

		//Create random diamonds
		for(int i=0;i<numberOfDiamonds;i++) {
			int value = Zufallsgenerator.zufallszahl(1, 5);
			int x = Zufallsgenerator.zufallszahl(0, gui.getBreite()-20);
			int y = Zufallsgenerator.zufallszahl(0, gui.getHoehe()-20);
			entities.add(new Diamond(x, y, value));
		}
		
		//Add snake
		entities.add(new Snake(50, 50, 10, 40));
		
		gui.repaint();	
	}
	
	/**
	 * Create game object to start the game
	 * 
	 * @param args
	 */
	public static void main(String[] args) {
		Game game = new Game();
	}

}
