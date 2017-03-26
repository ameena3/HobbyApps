package servletPackage;

import java.io.IOException;

/**
 * Servlet implementation class Servlet
 */
@WebServlet(description = "This is a servlet", urlPatterns = { "/Servlet" })
@ServletSecurity(@HttpConstraint rolesAllowed={"admin", "guest"})
public class Servlet extends HttpServlet implements SingleThreadModel {
	private static final long serialVersionUID = 1L;

	private int count = 0;
	
	protected synchronized void increment() {
		count++;
	}
	
	protected synchronized void decrement() {
		count--;
	}
	
	protected synchronized int getCount() {
		return count;
	}
	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		System.out.println("Is this html?");
		PrintWriter writer = response.getWriter();
		String searchTerm = request.getParameter("searchTerm");
		writer.println("You searched for..." + searchTerm);
	}

}
