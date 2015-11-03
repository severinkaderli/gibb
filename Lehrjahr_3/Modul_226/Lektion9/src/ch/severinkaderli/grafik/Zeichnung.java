package ch.severinkaderli.grafik;

import java.awt.Graphics;
import java.util.ArrayList;
import java.util.List;

public class Zeichnung {

		/**
		 * Liste die alle Figuren der Zeichnung enthält.
		 */
		private List<Figur> shapes = new ArrayList<Figur>();
		
		/**
		 * Delegiert das Zeichnen an die einzelnen Figuren
		 * 
		 * @param g
		 */
		public void zeichne(Graphics g) {
			this.shapes.forEach(shape -> shape.zeichne(g));
		}
		
		/**
		 * Fügt der Zeichnung eine neue Figur hinzu
		 * 
		 * @param figur Figur die hinzugefügt wird.
		 */
		public void addFigur(Figur figur) {
			this.shapes.add(figur);
		}
		
		/**
		 * Entfernt eine Figur von der Zeichnung.
		 * 
		 * @param figur Figur, die entfertn wird.
		 */
		public void removeFigur(Figur figur) {
			this.shapes.remove(figur);
		}
		
		/**
		 * @param figur
		 * @param dx
		 * @param dy
		 */
		public void moveFigur(Figur figur, int dx, int dy) {
			figur.move(dx, dy);
		}
}
