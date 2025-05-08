using FinanceApp.Data;
using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    public class ExpensesController : Controller
    {
        //accesss contexts so we can interact with db
        private readonly FinanceAppContext _context;
        public ExpensesController(FinanceAppContext context)
        {
            _context = context;
        }

        public IActionResult Index() //action method
        {
            var expenses = _context.Expenses.ToList(); //data  fom db
            return View(expenses);
        }
        public IActionResult Create() //action method
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Expense expense) //action method
        {
            if (ModelState.IsValid)
            {
                _context.Expenses.Add(expense);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expense);
        }
    }
}
