using EntityLayer.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class RealEstateContext:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("data source=SERCAN;initial catalog=MyRealEstate;user id=sa;password=wv2l5ct7m22056;");
            optionsBuilder.UseSqlServer(@"data source=.\MSSQLSERVER2019;initial catalog=MyRealEstate;user id=sercanmidik;password=Wv2l5ct7m22056;");

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactUs> ContactUses { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<GetInTouch> GetInTouches { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SliderTitle> SliderTitles { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<TeamFriend> TeamFriends { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ProductProperty> ProductProperties { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }


    }
}
