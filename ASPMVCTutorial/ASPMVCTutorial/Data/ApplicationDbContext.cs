using Microsoft.EntityFrameworkCore;
using ASPMVCTutorial.Models;

namespace ASPMVCTutorial.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
