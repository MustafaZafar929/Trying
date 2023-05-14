using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Trying.Models;

namespace Trying.Controllers
{
    public class BioDataController : Controller
    {
        private readonly AccountDbContext _dbContext;

        public BioDataController(AccountDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: BioData/Information
        public ActionResult Information()
        {
            var bioData = _dbContext.BioData.FirstOrDefault();
            return View(bioData);
        }

        // GET: BioData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BioData/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BioData bioData)
        {
            if (ModelState.IsValid)
            {
                _dbContext.BioData.Add(bioData);
                _dbContext.SaveChanges();
                return RedirectToAction("Index", "Home"); // Redirect to home page or a success page
            }

            return View(bioData);
        }
    }
}






//using System.Linq;
//using Microsoft.AspNetCore.Mvc;
//using Trying.Models;

//namespace Trying.Controllers
//{
//    public class BioDataController : Controller
//    {
//        private readonly AccountDbContext _dbContext;

//        public BioDataController(AccountDbContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        // GET: BioData/Information
//        public ActionResult Information()
//        {
//            var bioData = _dbContext.BioData.FirstOrDefault();
//            return View(bioData);
//        }

//        // GET: BioData/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: BioData/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(BioData bioData)
//        {
//            if (ModelState.IsValid)
//            {
//                // Get the logged-in user's account information
//                Account loggedInUser = _dbContext.Accounts.FirstOrDefault(a => a.Username == User.Identity.Name);

//                if (loggedInUser != null)
//                {
//                    // Associate the BioData with the logged-in user
//                    bioData.AccountId = loggedInUser.AccountId;

//                    // Add the BioData to the database and save changes
//                    _dbContext.BioData.Add(bioData);
//                    _dbContext.SaveChanges();

//                    return RedirectToAction("Index", "Home"); // Redirect to home page or a success page
//                }
//                else
//                {
//                    // Handle the case where the logged-in user's account information is not found
//                    return RedirectToAction("Login", "Account"); // Redirect to the login page or handle the error accordingly
//                }
//            }

//            return View(bioData);
//        }
//    }
//}