using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>     // IdentityDbContext den miras al dedik (ctrl . yaptık EntityFrameworkCore u kütüphaneye ekledik)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VEMFHFH\\SQLEXPRESS;Database=DbNewOopCore5;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Product> Products { get; set; }     //Ctrl . yaparak ilgili kütüphaneyi ekledik
        public DbSet<Customer> Customers { get; set; }    //sonuna s takısı gelince tablo olmuş oluyor
        public DbSet<Category> Categories { get; set; }   //bunları ekledikten sonra package manager console u acıp Data acces layer ı secip  tablolarımızı oluşturacağız
        public DbSet<Job> Jobs { get; set; }  
    }
}
