package ch.severinkaderli.grafik;

import java.awt.Graphics;
import java.util.ArrayList;
import java.util.List;

public class Zeichnung {

		private List<Figur> shapes = new ArrayList<Figur>();
		
		public Zeichnung(List<Figur> shapes) {
			this.shapes = shapes;
		}
		
		public void zeichne(Graphics g) {
			this.shapes.forEach(shape -> shape.zeichne(g));
		}
}
