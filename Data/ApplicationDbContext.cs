using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Hotel.Data.Identity;
namespace Hotel.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (builder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(Order)))
            {
                builder.Entity<Order>().Property(Z => Z.ID).UseIdentityColumn();
                base.OnModelCreating(builder);
                builder.Entity<Order>().HasData(
                    new Order(1, 4, DateTime.Now, DateTime.Now.AddDays(5)));
                    
            }
            else if (builder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(RoleModel)))
            {
                builder.Entity<RoleModel>().Property(Z => Z.ID).UseIdentityColumn();
                base.OnModelCreating(builder);
                builder.Entity<RoleModel>().HasData(
                    new RoleModel
                    {
                        ID = 111232344,
                        RoleName = "Admin",
                    });
            }
            else if (builder.Model.GetEntityTypes().Any(t => t.ClrType == typeof(StaffClass)))
            {
                builder.Entity<StaffClass>().Property(Z => Z.ID).UseIdentityColumn();
                base.OnModelCreating(builder);
                builder.Entity<StaffClass>().HasData(
                    new StaffClass
                    {
                        ID = 1,
                        Name = "TestStaffName",
                        JobTitle = "PlayBoy",
                        Email = "mask@gmail.com",
                        salary = 2000,
                    });
            }
        }
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<RoleModel> Roles { get; set; }
        public DbSet<StaffClass> Staff { get; set; } = default!;

        /*Budget hbudget = new Budget(1000);
        HotelClass hotelObj = new HotelClass("HotelName");*/


    }
}
