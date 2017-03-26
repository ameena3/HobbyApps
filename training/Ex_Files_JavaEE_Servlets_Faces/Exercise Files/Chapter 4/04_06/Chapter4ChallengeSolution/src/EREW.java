
public class EREW {

	String text = "EREW:0";
	boolean lock = false;
	
	public EREW() {
		
	}
	
	public void read() {
		if(!lock) {
			System.out.println(text);
			lock = true;
		}
	}

	public void write(String text) {
		if(!lock) {
			this.text = "EREW:" + text;
			lock = true;
		}
	}

}
