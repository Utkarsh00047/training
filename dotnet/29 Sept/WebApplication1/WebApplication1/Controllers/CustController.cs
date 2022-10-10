using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustController : Controller
    {
        private readonly dbfirstContext _context;
        public CustController(dbfirstContext context)
        {
            _context = context;
        }

        public IActionResult View()
        {
            List<Cust> customers = _context.Custs.ToList();
            return View(customers);
        }

        public IActionResult Details(string Id)
        {
            Cust customer = _context.Custs.Where(p => p.CustId.ToString() == Id.ToString()).FirstOrDefault();
            return View(customer);
        }
        [HttpGet]
        public IActionResult Edit(string Id)
        {
            Cust customer = _context.Custs.Where(p => p.CustId.ToString() == Id.ToString()).FirstOrDefault();
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Cust cust)
        {
            _context.Attach(cust);
            _context.Entry(cust).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("View");

        }
        [HttpGet]
        public IActionResult Delete(string Id)
        {
            Cust customer = _context.Custs.Where(p => p.CustId.ToString() == Id.ToString()).FirstOrDefault();
            return View(customer);
        }
        [HttpPost]
        public IActionResult Delete(Cust cust)
        {
            _context.Attach(cust);
            _context.Entry(cust).State = EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("View");

        }
        [HttpGet]
        public IActionResult Create()
        {
            Cust customer = new Cust();
            return View(customer); 
        }

        [HttpPost]
        public IActionResult Create(Cust cust)
        {
            _context.Attach(cust);
            _context.Entry(cust).State = EntityState.Added;
            _context.SaveChanges();
            return RedirectToAction("View");
        }

    }
}
