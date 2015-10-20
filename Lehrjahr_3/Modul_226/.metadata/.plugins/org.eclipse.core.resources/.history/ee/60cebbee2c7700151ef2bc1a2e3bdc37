package ch.severinkaderli.grafik;

import java.awt.Graphics;
import java.util.ArrayList;
import java.util.List;

public class Zeichnung {

		private List<Figur> shapes = new ArrayList<Figur>();
		
		
		public void zeichne(Graphics g) {
			this.shapes.forEach(shape -> shape.zeichne(g));
		}
		
		public void addFigur(Figur figur) {
			this.shapes.add(figur);
		}
		
		public void printElements() {
			this.shapes.forEach(shape -> System.out.println(shape.toString()));
		}
}
