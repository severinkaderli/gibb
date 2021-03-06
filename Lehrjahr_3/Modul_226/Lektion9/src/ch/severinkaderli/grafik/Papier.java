package ch.severinkaderli.grafik;

import java.awt.Graphics;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

import javax.swing.JPanel;

/**
 * Papier ist eine von JPanel abgeleitete Swing-Komponente. - Sie dient als
 * "Zeichenblatt" f�r Zeichnungen. - Sie speichert die Zeichnung in einer
 * Instanzvariablen. - Sie �berschreibt die Methode paintComponent der Klasse
 * JPanel so, dass bei ihrem Aufruf die Zeichnung auf das Papier gezeichnet
 * wird.
 * 
 * @author Andres Scheidegger
 */
@SuppressWarnings("serial")
public class Papier extends JPanel {

	/**
	 * Die Zeichnung.
	 */
	private Zeichnung zeichnung;

	private int x, y;

	/**
	 * Enum f�r die verschiedenen Zeichnungsmodi
	 */
	public enum DrawingMode {
		RECTANGLE, LINE, CIRCLE
	}

	private DrawingMode currentMode = DrawingMode.RECTANGLE;

	public Papier() {
		addMouseListener(new PapierMouseListener());
		addKeyListener(new PapierKeyListener());
		// This is needed for the KeyListener to work
		setFocusable(true);
	}

	@Override
	public void paintComponent(final Graphics g) {
		super.paintComponent(g);
		if (zeichnung != null)
			zeichnung.zeichne(g);
	}

	public void setZeichnung(final Zeichnung zeichnung) {
		this.zeichnung = zeichnung;
	}

	/**
	 * MouseListener for Drawing the shapes
	 */
	private class PapierMouseListener extends MouseAdapter {
		public void mousePressed(MouseEvent e) {
			x = e.getX();
			y = e.getY();
		}

		public void mouseReleased(MouseEvent e) {

			Figur figur;
			switch (currentMode) {
			case RECTANGLE:
			default:
				// TODO: Get Calculation for negative values right
				int width = e.getX() - x;
				int height = e.getY() - y;

				figur = new Rechteck(x, y, width, height);

				break;
			case LINE:

				figur = new Linie(x, y, e.getX(), e.getY());

				break;
			case CIRCLE:

				// Calculate radius with the pythogerean theorem
				int dx = Math.abs(e.getX()) - x;
				int dy = Math.abs(e.getY()) - y;
				int radius = (int) Math.sqrt(Math.pow(dx, 2) + Math.pow(dy, 2));
				figur = new Kreis(x, y, radius);
				break;
			}

			zeichnung.addFigur(figur);
			repaint();
		}
	}

	/**
	 * KeyListener for switching current Drawing Mode
	 */
	private class PapierKeyListener extends KeyAdapter {
		public void keyPressed(KeyEvent e) {
			switch (e.getKeyChar()) {
			case 'r':
				currentMode = DrawingMode.RECTANGLE;
				break;

			case 'l':
				currentMode = DrawingMode.LINE;
				break;

			case 'k':
				currentMode = DrawingMode.CIRCLE;
				break;
			}
			System.out.println(currentMode);
		}
	}
}
