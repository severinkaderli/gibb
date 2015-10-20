package ch.severinkaderli.grafik;

import java.awt.Graphics;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

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
public class Papier extends JPanel implements MouseListener, KeyListener {

	/**
	 * Die Zeichnung.
	 */
	private Zeichnung zeichnung;

	private int x, y;

	/**
	 * Enum for the different Drawing Modes
	 */
	public enum DrawingMode {
		RECTANGLE, LINE, CIRCLE
	}

	private DrawingMode currentMode = DrawingMode.RECTANGLE;

	public Papier() {
		addMouseListener(this);
		addKeyListener(this);
		//This is needed for the KeyListener to work
		setFocusable(true);
	}

	/**
	 * Die Methode paintComponent zeichnet die Zeichnung auf das Papier. Sie
	 * erh�lt dazu ein Graphics-Objekt, welches sie an die Zeichnung weitergibt.
	 * 
	 * @param g
	 *            Graphics-Objekt, welches zum zeichnen verwendet werden soll.
	 * @see javax.swing.JComponent#paintComponent(java.awt.Graphics)
	 */
	@Override
	public void paintComponent(final Graphics g) {
		super.paintComponent(g);
		if (zeichnung != null)
			zeichnung.zeichne(g);
	}

	/**
	 * Setter f�r die Instanzvariable zeichnung.
	 * 
	 * @param zeichnung
	 *            Die zu zeichnende Zeichnung.
	 */
	public void setZeichnung(final Zeichnung zeichnung) {
		this.zeichnung = zeichnung;
	}

	/**
	 * Mouse Events for Drawing the shapes
	 */
	@Override
	public void mousePressed(MouseEvent e) {
		x = e.getX();
		y = e.getY();
	}

	@Override
	public void mouseReleased(MouseEvent e) { 
		
		Figur figur;
		switch(currentMode) {
		case RECTANGLE:
		default:
			//TODO: Get this calculation right...
			int tmp = 0;
			int width = e.getX() - x;
			int height = e.getY() - y;
			
			
			/*if(x2 < x) {}
				tmp = x2;
				x = x2;
				x2 = tmp;
			if(y2 < y) {
				tmp = y2;
				y = y2;
				y2 = tmp;
			}*/
			
			figur = new Rechteck(x, y, width, height);
			
			break;
		case LINE:
			
			figur = new Linie(x, y, e.getX(), e.getY());
			
			break;
		case CIRCLE:
			
			//Calculate radius exactly
			int dx = Math.abs(e.getX()) - x;
			int dy = Math.abs(e.getY()) - y;
			int radius = (int)Math.sqrt(Math.pow(dx, 2) + Math.pow(dy, 2));
			figur = new Kreis(x, y, radius);
			break;			
		}
		
		zeichnung.addFigur(figur);
		repaint();
	}

	@Override
	public void mouseClicked(MouseEvent e) {
	}

	@Override
	public void mouseEntered(MouseEvent e) {
	}

	@Override
	public void mouseExited(MouseEvent e) {
	}

	/**
	 * Key events for switching drawing modes
	 * 
	 * r = Rectangles l = Lines k = Circles
	 */
	@Override
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

	@Override
	public void keyReleased(KeyEvent e) {
	}

	@Override
	public void keyTyped(KeyEvent e) {
	}
}
