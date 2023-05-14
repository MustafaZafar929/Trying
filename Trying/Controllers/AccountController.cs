using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trying.Models;

namespace Trying.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountDbContext _context;

        public AccountController(AccountDbContext context)
        {
            _context = context;
        }

        // GET: Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Account account)
        {
            if (ModelState.IsValid)
            {
                var result = await _context.Accounts.FirstOrDefaultAsync(a => a.Username == account.Username && a.Password == account.Password);

                if (result != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }

            return View(account);
        }

        // GET: Account/SignUp
        public IActionResult SignUp()
        {
            return View();
        }

        // POST: Account/SignUp
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(Account account)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _context.Accounts.FirstOrDefaultAsync(a => a.Username == account.Username);

                if (existingUser != null)
                {
                    ModelState.AddModelError(string.Empty, "Username already exists.");
                }
                else
                {
                    _context.Accounts.Add(account);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Login"); // Redirect to the Login action
                }
            }

            return View(account);
        }
    }
}
