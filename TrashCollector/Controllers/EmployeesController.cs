using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            var employeeId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var employee = _context.Employees.Where(e => e.IdentityUserId == employeeId).FirstOrDefault();

            var customer = _context.Customers
               .Where(c => c.Zipcode == employee.ZipCode).ToList();
              return View(customer);
        }

        //Sort by Day of Week
        public async Task<IActionResult> IndexDays()
        {
            var employeeId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var employee = _context.Employees.Where(e => e.IdentityUserId == employeeId).FirstOrDefault();

            var customer = _context.Customers
               .Where(c => c.DayOfWeek == DateTime.Today.DayOfWeek.ToString());
            return View(customer);
        }
        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {

                var employeeId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = employeeId;

                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Employees");
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id, Customer customer)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer1 = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer1);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Customer customer)
        {
            var editMyCustomer = _context.Customers.Find(id);
            if (id != editMyCustomer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    editMyCustomer.Balance = customer.Balance;
                    editMyCustomer.FirstName = customer.FirstName;
                    editMyCustomer.LastName = customer.LastName;


                    _context.Entry(editMyCustomer).State = EntityState.Modified;
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(customer.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        public ActionResult ConfirmPickup(int id)
        {
            
            Customer customer = _context.Customers.Find(id);
            customer.Balance += 50;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}
