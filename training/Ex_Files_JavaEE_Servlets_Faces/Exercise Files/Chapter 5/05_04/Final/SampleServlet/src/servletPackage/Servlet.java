package servletPackage;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.ServletSecurity;
import javax.servlet.annotation.HttpConstraint;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class Servlet
 */
@ServletSecurity(@HttpConstraint rolesAllowed={"admin", "guest"})
@WebServlet(description = "This is a servlet", urlPatterns = { "/Servlet" })
public class Servlet extends HttpServlet implements javax.servlet.Servlet {
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