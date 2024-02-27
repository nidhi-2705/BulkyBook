using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Outlook;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {    
        }

        public DbSet<CategoryModel> Categories { get; set; } 
    }
}
