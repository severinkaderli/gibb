package ch.severinkaderli.grafik;

import java.util.ArrayList;
import java.util.Arrays;

public class Test {

	public static void main(String[] args) {
		Linie linie = new Linie(100, 200);
		Rechteck square = new Rechteck(50, 200, 300, 40);
		
		Zeichnung zeichnung = new Zeichnung(Arrays.asList(linie, square));
	}

}
