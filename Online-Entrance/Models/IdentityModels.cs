using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Online_Entrance.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(255)]
        public string SchoolName { get; set; }

        [Required]
        [StringLength(255)]
        public string SeeSymbolNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Gpa { get; set; }

        [Required]
        [StringLength(255)]
        public string Dob { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [StringLength(255)]
        public string GuardianName { get; set; }

        [Required]
        [StringLength(255)]
        public string GuardianContact { get; set; }

        [Required]
        [StringLength(255)]
        public string Faculty { get; set; }

        public DateTime RegisteredDate { get; set; }




        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<ExamGiver> ExamGivers { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}