package servletPackage;

import javax.annotation.security.DeclareRoles;
import javax.annotation.security.RolesAllowed;
import javax.servlet.ServletContext;
import javax.servlet.ServletContextAttributeEvent;
import javax.servlet.ServletContextAttributeListener;

@DeclareRoles(value={"admin", "guest"})
public class WebContext implements ServletContextAttributeListener {

	private ServletContext context = null;

	@Override
	@RolesAllowed({"admin", "guest"})
	public void attributeAdded(ServletContextAttributeEvent arg0) {
		context = arg0.getServletContext();
		System.out.println(arg0.getValue() + " was created");
	}

	@Override
	@RolesAllowed("admin")
	public void attributeRemoved(ServletContextAttributeEvent arg0) {
		context = arg0.getServletContext();
		System.out.println(arg0.getValue() + " was removed");
	}

	@Override
	public void attributeReplaced(ServletContextAttributeEvent arg0) {
		context = arg0.getServletContext();
		System.out.println(arg0.getValue() + " was changed");
	}
	

}
