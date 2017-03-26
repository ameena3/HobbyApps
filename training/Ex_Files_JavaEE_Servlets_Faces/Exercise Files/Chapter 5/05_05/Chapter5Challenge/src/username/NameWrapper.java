package username;


public class NameWrapper {

	private String name;
	private String address;
	private String zip;
	private String outtext;
	
	public String getName() {
		return name;
	}
	
	public void setName(String name) {
		name = name;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		address = address;
	}

	public String getZip() {
		return zip;
	}

	public void setZip(String zip) {
		zip = zip;
	}

	public String getOuttext() {
		return name + zip + address;
	}

	public void setOuttext(String outtext) {
		outtext = outtext;
	}
	
}
