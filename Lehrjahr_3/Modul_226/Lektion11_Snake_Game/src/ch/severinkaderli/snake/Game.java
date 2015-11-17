package ch.severinkaderli.snake;

import java.awt.Graphics;
import java.util.ArrayList;
import java.util.List;

public class Game {

	/**
	 * Die Schlange, die man Steuert.
	 */
	public Snake snake;
	
	/**
	 * Der Rahmen des Spielfeldes
	 */
	public Border border;
	
	/**
	 * Die aktuelle Punktzahl
	 */
	private int score = 0;

	/**
	 * Liste, welche alle Diamanten enthält
	 */
	private static List<Diamond> diamonds = new ArrayList<Diamond>();

	/**
	 * Anzahl der Diamanten, die auf dem Feld erschienen sollen.
	 */
	final private int NUMBER_OF_DIAMONDS = 10;
	
	/**
	 * Radius der Diamanten
	 */
	final private int DIAMOND_RADIUS = 20;

	/**
	 * Schrittweite, um die sich die Schlange bei jedem Tick bewegt.
	 */
	final private int STEP_SIZE = 2;

	/**
	 * Anzahl der Ticks pro Sekunde
	 */
	final private int TICKS_PER_SECOND = 16;

	/**
	 * Abstand vom Border zum Fensterrand.
	 */
	final private int AREA_PADDING = 10;

	/**
	 * Delegiert das zeichnen an die einzelnen Elemente
	 * 
	 * @param g
	 */
	public void draw(Graphics g) {
		border.draw(g);
		snake.draw(g);
		diamonds.forEach(diamond -> diamond.draw(g));
		g.drawString(String.valueOf(score),10, 10);
	}

	/**
	 * Erstellt die Elemente, die für das Spiel nötig sind und zeigt am Schluss
	 * das Feld an.
	 */
	public Game() {

		// Das Spielbrett initialisieren
		GUI gui = new GUI(this);

		// Spielbegrenzung einfügen
		int borderWidth = gui.getBreite() - 2 * AREA_PADDING;
		int borderHeight = gui.getHoehe() - 2 * AREA_PADDING;
		border = new Border(AREA_PADDING, AREA_PADDING, borderWidth,
				borderHeight);

		// Diamanten an zufälliger Position auf dem Feld erscheinen lassen.
		for (int i = 0; i < NUMBER_OF_DIAMONDS; i++) {
			int value = Zufallsgenerator.zufallszahl(1, 5);
			int x = Zufallsgenerator.zufallszahl(AREA_PADDING, AREA_PADDING
					+ borderWidth-DIAMOND_RADIUS);
			int y = Zufallsgenerator.zufallszahl(AREA_PADDING, AREA_PADDING
					+ borderHeight-DIAMOND_RADIUS);
			diamonds.add(new Diamond(x, y, DIAMOND_RADIUS, DIAMOND_RADIUS, value));
		}

		// Add snake
		snake = new Snake(300, 100, 10, 10, this);

		// Main Game Loop
		while (true) {
			loop();
			gui.repaint();
		}

	}

	/**
	 * Main loop-Funktion für das Spiel, hier werden die einzelnen Ticks des
	 * Spieles durchgeführt und dabei wird immer die Schlange bewegt.
	 */
	public void loop() {
		try {
			Thread.sleep(TICKS_PER_SECOND);
			snake.move(STEP_SIZE);
			

			// Read key strokes and change direction of snake
		} catch (InterruptedException e) {

		}
	}
	
	/**
	 * Gibt die Liste der aktuellen Diamanten zurück.
	 * 
	 * @return
	 */
	public List<Diamond> getDiamonds() {
		return diamonds;
	}
	
	public void setScore(int score) {
		this.score = score;
	}
	
	public int getScore() {
		return score;
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
