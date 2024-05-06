using Microsoft.AspNetCore.Mvc;
using TaskWeb1.Data;

namespace TaskWeb1.Controllers
{
	public class EmployeeController : Controller
	{
		ApplicationDbContext context = new ApplicationDbContext();
		public IActionResult Index()
		{
			var emp = context.Employees.ToList();
			return View("Index",emp);
		}
	}
}
