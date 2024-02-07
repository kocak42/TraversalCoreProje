
using Entity.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate;

public class Context :IdentityDbContext<AppUser, AppRole, int>
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; Database=TraversalDB2;integrated security=true");
    }
    public DbSet<FirstAbout> FirstAbouts { get; set; }
    public DbSet<SecondAbout> SecondAbouts { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<BannerAbout> BannerAbouts { get; set; }
    public DbSet<Destination > Destinations { get; set; }
    public DbSet<Contact > Contacts { get; set; }
    public DbSet<Newslatter > Newslatters { get; set; }
    public DbSet<FirstFeature> FirstFeatures { get; set; }
    public DbSet<SecondFeature> secondFeatures{ get; set; }
    public DbSet<Testimonial> Testimonials{ get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Reservation> Reservations { get; set; }



}
