using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RealEstateContext>();
builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<RealEstateContext>();

var requireAuthorizePolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

builder.Services.AddScoped<IBrandService, BrandManager>();
builder.Services.AddScoped<IBrandDal, EfBrandDal>();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EfContactDal>();

builder.Services.AddScoped<IContactUsService, ContactUsManager>();
builder.Services.AddScoped<IContactUsDal, EfContactUsDal>();

builder.Services.AddScoped<IGalleryService, GalleryManager>();
builder.Services.AddScoped<IGalleryDal, EfGalleryDal>();

builder.Services.AddScoped<IGetInTouchService, GetInTouchManager>();
builder.Services.AddScoped<IGetInTouchDal, EfGetInTouchDal>();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDal, EfProductDal>();

builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IServiceDal, EfServiceDal>();

builder.Services.AddScoped<ISliderTitleService, SliderTitleManager>();
builder.Services.AddScoped<ISliderTitleDal, EfSliderTitleDal>();

builder.Services.AddScoped<ISubCategoryService, SubCategoryManager>();
builder.Services.AddScoped<ISubCategoryDal, EfSubCategoryDal>();

builder.Services.AddScoped<ITeamFriendService, TeamFriendManager>();
builder.Services.AddScoped<ITeamFriendDal, EfTeamFriendDal>();

builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();

builder.Services.AddScoped<IProductDetailService, ProductDetailManager>();
builder.Services.AddScoped<IProductDetailDal, EfProductDetailDal>();

builder.Services.AddScoped<IProductPropertyService, ProductPropertyManager>();
builder.Services.AddScoped<IProductPropertyDal, EfProductPropertyDal>();

builder.Services.AddControllersWithViews(opt =>
{
    opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy));
});
 builder.Services.ConfigureApplicationCookie(options => {
    options.LoginPath = new PathString("/Account/Login");
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    //options.AccessDeniedPath = new PathString("/Account/AccessDenied");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
