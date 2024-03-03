using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
        public DbSet<RoomType>? RoomTypes { get; set; }
        public DbSet<Booking>? Bookings { get; set; }
        public DbSet<Room>? Rooms { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Hostel>? Hostels { get; set; }
        public DbSet<Payment>? Payments { get; set; }
    }
}
