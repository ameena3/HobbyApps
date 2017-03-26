
public class EREW {

	String text = "EREW:0";
	
	public EREW() {
		
	}
	
	public void read() {
		System.out.println(text);
	}

	public void write(String text) {
		this.text = "EREW:" + text;
	}

}
