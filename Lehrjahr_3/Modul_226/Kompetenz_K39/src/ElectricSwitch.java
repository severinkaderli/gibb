
public class ElectricSwitch implements Switch {

	public Switchable client;
	public boolean powered;
	
	public ElectricSwitch(Switchable client) {
		this.client = client;
		powered = false;
	}
	
	public void press() {
		if(isPowered()) {
			client.turnOff();
			powered = false;
		} else {
			client.turnOn();
			powered = true;
		}
		
	}
	
	public boolean isPowered() {
		return powered;
	}
}
