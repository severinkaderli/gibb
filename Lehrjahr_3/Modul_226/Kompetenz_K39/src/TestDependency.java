
public class TestDependency {
	public static void main(String[] args) {
		Switchable lampe = new Lamp();
		Switch schalter = new ElectricSwitch(lampe);
		schalter.press();
		schalter.press();
	}
}
