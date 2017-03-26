package roadgraph;

import java.util.LinkedList;
import java.util.List;

import geography.GeographicPoint;

public class mapNode {
	private GeographicPoint location;
	public List<mapEdges> edges;
	public GeographicPoint getLocation() {
		return location;
	}
	public void setLocation(GeographicPoint location) {
		this.location = location;
	}
	
	public mapNode() {
		edges = new LinkedList<>();
	}

}
