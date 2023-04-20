using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetSitter.Data;
using PetSitter.Models;
using PetSitter.Repositories;
using PetSitter.ViewModels;

namespace PetSitter.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly PetSitterContext _db;
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly SitterRepos sitterRepos;
        private readonly CustomerRepo customerRepo;
        private readonly PetRepo petRepo;
        private readonly AdminRepo adminRepo;
        

        public AdminController(ILogger<AdminController> logger, PetSitterContext db, IWebHostEnvironment webHost, ApplicationDbContext context )
        {
            _logger            = logger;
            _db                = db;
            webHostEnvironment = webHost;
            _context           = context;

            sitterRepos  = new SitterRepos(_db, webHostEnvironment);
            customerRepo = new CustomerRepo(_db, webHostEnvironment);
            petRepo      = new PetRepo(_db, webHostEnvironment);
            adminRepo    = new AdminRepo(_db, webHostEnvironment, _context);

        }

        public IActionResult AdminDashboard()
        {
            var allUsers = adminRepo.GetAllUsers();

            return View(allUsers);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
