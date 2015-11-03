package ch.severinkaderli.grafik;


public class Test {

	public static void main(String[] args) {
		
		Zeichnung zeichnung = new Zeichnung();
		zeichnung.addFigur(new Rechteck(10, 10, 20, 30));
		zeichnung.addFigur(new Linie(15, 20, 30, 50));
		
		Zeichenbrett z = new Zeichenbrett();
		z.zeige(zeichnung);
	}

}
