import java.util.Observable;
import java.util.Observer;


public class Zuschauer implements Observer {

	private String name;
	
	public Zuschauer(String name) {
		setName(name);
	}
	
	public void setName(String name) {
		this.name = name;
	}
	
	public String getName() {
		return name;
	}
	
	@Override	
	public void update(Observable o, Object arg) {
		System.out.println("Zuschauer " + getName() + " schaut nun den Kanal: " + arg);
	}
}
