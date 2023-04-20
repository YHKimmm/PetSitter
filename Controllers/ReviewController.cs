using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PetSitter.Data.Services;
using PetSitter.Models;

namespace PetSitter.Controllers
{
    public class ReviewController : Controller
    {

        private readonly PetSitterContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public ReviewController(PetSitterContext db, IWebHostEnvironment webHost)
        {
            _db = db;
            _webHostEnvironment = webHost;
        }

        public IActionResult Index()
        {
            return View();
        }

        

    }










}
