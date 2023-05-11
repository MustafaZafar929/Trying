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
                var result = await _context.accounts.FirstOrDefaultAsync(a => a.Username == account.Username && a.Password == account.Password);

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
    }
}


