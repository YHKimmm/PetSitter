using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PetSitter.Data;
using PetSitter.Models;
using PetSitter.ViewModels;

namespace PetSitter.Repositories
{
    public class AdminRepo
    {
        private readonly PetSitterContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ApplicationDbContext _context;
      
        public AdminRepo(PetSitterContext db, IWebHostEnvironment webHostEnvironment, ApplicationDbContext context)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
            _context = context;
 
            
        }

        public IQueryable GetAllUsers() 
        {

            var allUsers = (from user in _db.Users
                            select new AdminDashboardVM
                            {
                                UserID = user.UserId,
                                Email = user.Email,
                                FirstName = user.FirstName,
                                LastName = user.LastName,
                                Role = user.UserType
                            }) ;

            return allUsers;

           
        }
    }
}
