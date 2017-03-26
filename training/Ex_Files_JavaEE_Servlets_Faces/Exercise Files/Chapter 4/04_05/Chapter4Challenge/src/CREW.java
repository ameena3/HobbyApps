
public class CREW {

	String text = "CREW:0";
	
	public CREW() {
		
	}
	
	public void read() {
		System.out.println(text);
	}

	public void write(String text) {
		this.text = "CREW:" + text;
	}

}
