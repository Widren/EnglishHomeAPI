using BaseAPI.Core.Models;
using BaseAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BaseAPI.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.ParentID);
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Category>().Property(p => p.Icon);
            builder.Entity<Category>().HasData
            (
                new Category { Id = 100, Name = "Yatak Odası", Icon= "https://github.com/Widren/EnglishHome-EShopTemplateIntegrated/blob/main/Images/YatakOdasi.jpg?raw=true" },
                new Category { Id = 101, Name = "Mutfak", Icon = "https://github.com/Widren/EnglishHome-EShopTemplateIntegrated/blob/main/Images/mutfak.jpg?raw=true" },
                new Category { Id = 102, Name = "Banyo", Icon = "https://github.com/Widren/EnglishHome-EShopTemplateIntegrated/blob/main/Images/banyo.jpg?raw=true" },
                new Category { Id = 103, Name = "Salon", Icon = "https://github.com/Widren/EnglishHome-EShopTemplateIntegrated/blob/main/Images/YatakOdasi.jpg?raw=true" },

                new Category { Id = 104, ParentID = 100, Name = "Battaniye" },
                new Category { Id = 105, ParentID = 100, Name = "Nevresim Seti" },
                new Category { Id = 106, ParentID = 100, Name = "Yastık" },
                new Category { Id = 107, ParentID = 100, Name = "Yorgan" },

                new Category { Id = 108, ParentID = 101, Name = "Tencere" },
                new Category { Id = 109, ParentID = 101, Name = "Kavanoz" },
                new Category { Id = 110, ParentID = 101, Name = "Fincan Seti" },
                new Category { Id = 111, ParentID = 101, Name = "Yemek Takımı" },

                new Category { Id = 112, ParentID = 102, Name = "Havlu" },
                new Category { Id = 113, ParentID = 102, Name = "Sabunluk" },
                new Category { Id = 114, ParentID = 102, Name = "Bornoz" },
                new Category { Id = 115, ParentID = 102, Name = "Banyo Seti" },

                new Category { Id = 116, ParentID = 103, Name = "Halı" },
                new Category { Id = 117, ParentID = 103, Name = "Kırlent" },
                new Category { Id = 118, ParentID = 103, Name = "Masa Örtüsü" },
                new Category { Id = 119, ParentID = 103, Name = "Sehpa" }


            );
            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired();
            builder.Entity<Product>().Property(p => p.ImageURL).IsRequired();
            builder.Entity<Product>().Property(p => p.Color).IsRequired();
            builder.Entity<Product>().Property(p => p.Cost).IsRequired();
            builder.Entity<Product>().Property(p => p.CategoryID).IsRequired();
            builder.Entity<Product>().Property(p => p.rating).IsRequired();

            builder.Entity<Product>().HasData
            (
                new Product { Id= 101, Name = "Softy Wellsoft Tv Battaniye 120x170 Cm Çikolata", Cost = 149.99, ImageURL = "https://cdn-eh.akinon.net/products/2021/10/05/189290/a3dbd199-bf0d-4f02-9921-d552b60eca6c_size768x575_cropCenter.jpg", Color = "Çikolata", rating = 0.0, CategoryID = 104 },
                new Product { Id= 102, Name = "Liberty Bloom Pamuklu Çift Kişilik Nevresim Seti 200x220 Cm Tarçın", Cost = 499.99, ImageURL = "https://cdn-eh.akinon.net/products/2022/02/25/205114/462482ba-4a25-4fa4-9937-7bb5fa5efce5_size768x575_cropCenter.jpg", Color = "Pembe", rating = 0.0, CategoryID = 105},
                new Product { Id= 103, Name = "Silikonlu Yastık 50X70 Cm Ekru", Cost = 99.99, ImageURL = "https://cdn-eh.akinon.net/products/2019/02/12/48498/3c437f1f-03d6-46f0-bec6-481e9d41c202_size768x575_cropCenter.jpg", Color = "Beyaz", rating = 0.0, CategoryID = 106 },
                new Product { Id= 104, Name = "Siesta Mikrofiber Çift Kişilik Yorgan 195x215 Cm Beyaz", Cost = 499.99, ImageURL = "https://cdn-eh.akinon.net/products/2020/05/07/64997/b7f1464b-c40b-4ac0-8eb7-3d7842f0ae81_size768x575_cropCenter.jpg", Color = "Beyaz", rating = 0.0, CategoryID = 107 },

                new Product { Id= 105, Name = "Icy Alüminyum Döküm Tencere Seti 7 Parça Siyah", Cost = 2449.99, ImageURL = "https://cdn-eh.akinon.net/products/2022/01/14/206695/4480a9c1-6fab-449b-923d-eb397607dfe7_size768x575_cropCenter.jpg", Color = "Siyah", rating = 0.0, CategoryID = 108 },
                new Product { Id= 106, Name = "Cassidy Cam Kavanoz 1100 Ml Şeffaf", Cost = 109.99, ImageURL = "https://cdn-eh.akinon.net/products/2021/12/24/197796/ec1814ce-fae1-4850-83ae-025f0b505fd3_size768x575_cropCenter.jpg", Color = "Kahverengi", rating = 0.0, CategoryID = 109 },
                new Product { Id= 107, Name = "Pamira Porselen 6 Kişilik Kahve Fincan Takımı 80 Ml Mavi", Cost = 249.99, ImageURL = "https://cdn-eh.akinon.net/products/2022/02/09/196669/bb0d9486-8962-4b22-82a0-73481aec8033_size768x575_cropCenter.jpg", Color = "Mavi", rating = 0.0, CategoryID = 110 },
                new Product { Id= 108, Name = "Galia Butterfly Bone Porselen 12 Parça Yemek Takımı 25 - 20 - 15 Cm Pembe", Cost = 1199.99, ImageURL = "https://cdn-eh.akinon.net/products/2021/11/29/195330/a7459148-84bc-499d-8320-a24ccc7da6c3_size768x575_cropCenter.jpg", Color = "Beyaz-Altın", rating = 0.0, CategoryID = 111 },

                new Product { Id= 109, Name = "Quadro Pamuklu 4'lü Set Havlu Seti 30x40 Cm Beyaz - Bordo", Cost = 119.99, ImageURL = "https://cdn-eh.akinon.net/products/2022/03/10/204593/4e3902ba-7b1b-46fb-ad47-b8fa438c09a3_size768x575_cropCenter.jpg", Color = "Beyaz", rating = 0.0, CategoryID = 112 },
                new Product { Id=110, Name = "Casa Cam Banyo Sıvı Sabunluk 8x14 Cm Gold", Cost = 29.99, ImageURL = "https://cdn-eh.akinon.net/products/2020/09/17/167357/c43642db-f0fa-405a-88e1-e43181c97838_size768x575_cropCenter.jpg", Color = "Beyaz", rating = 0.0, CategoryID = 113 },
                new Product { Id=111, Name = "Plain Pamuklu Bornoz L-xl Kiremit", Cost = 349.99, ImageURL = "https://cdn-eh.akinon.net/products/2022/04/19/210709/06c27a52-ab7c-4073-81ee-493f4acb79e8_size768x575_cropCenter.jpg", Color = "Kiremit", rating = 0.0, CategoryID = 114 },
                new Product { Id=112, Name = "Evelyn 3'lü Banyo Seti Bej", Cost = 299.99, ImageURL = "https://cdn-eh.akinon.net/products/2022/04/19/206923/8f568c3c-3064-4430-9ed8-ccdfd1d10567_size768x575_cropCenter.jpg", Color = "Bej", rating = 0.0, CategoryID = 115 },

                new Product { Id=113, Name = "Vera Şönil Halı Gri", Cost = 999.99, ImageURL = "https://cdn-eh.akinon.net/products/2021/06/22/180419/759d29d4-55cd-45cb-a235-3a63f2dc3482_size768x575_cropCenter.jpg", Color = "Gri", rating = 0.0, CategoryID = 116 },
                new Product { Id=114, Name = "Fluffy Peluş Kırlent Kılıfı 45x45 cm Mürdüm", Cost = 119.99, ImageURL = "https://cdn-eh.akinon.net/products/2021/11/29/192494/2bb51d63-c5cd-449e-83e7-7f4fee5ca2f2_size768x575_cropCenter.jpg", Color = "Mürdüm", rating = 0.0, CategoryID = 117},
                new Product { Id=115, Name = "Mace Polyester Masa Örtüsü 150x200 Cm Antrasit", Cost = 149.99, ImageURL = "https://cdn-eh.akinon.net/products/2021/11/22/200593/d5f45304-77be-4e51-8133-26639b95c3d6_size768x575_cropCenter.jpg", Color = "Mavi", rating = 0.0, CategoryID = 118},
                new Product { Id=116, Name = "Marcel Sehpa 30x30x30 Cm Krem", Cost = 249.99, ImageURL = "https://cdn-eh.akinon.net/products/2021/04/20/177084/ba615c13-ba1c-429a-a8e8-f01cbd393f97_size768x575_cropCenter.jpg", Color = "Krem", rating = 0.0, CategoryID = 119 }
            );


            builder.Entity<Siparis>().ToTable("Siparis");
            builder.Entity<Siparis>().HasKey(p => p.SiparisId);
            builder.Entity<Siparis>().Property(p => p.SiparisId).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Siparis>().Property(p => p.Adet).IsRequired();
            builder.Entity<Siparis>().Property(p => p.UserId).IsRequired();
            builder.Entity<Siparis>().Property(p => p.ProductID).IsRequired();
            /*builder.Entity<Siparis>().HasData
            (
                 new Siparis
                 {
                     SiparisId = 1,
                     Adet = 1,
                     UserId = 1,
                     ProductID = 100
                 },
                new Siparis
                {
                    SiparisId = 2,
                    Adet = 1,
                    UserId = 2,
                    ProductID = 101
                }
             );*/

            builder.Entity<UserRole>().HasKey(ur => new { ur.UserId, ur.RoleId });




            builder.Entity<User>().ToTable("User");
            builder.Entity<User>().HasKey(p => p.Id);
            builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<User>().Property(p => p.Email).IsRequired();
            builder.Entity<User>().Property(p => p.Name).IsRequired();
            builder.Entity<User>().Property(p => p.LastName).IsRequired();
            builder.Entity<User>().Property(p => p.UserName).IsRequired();
            builder.Entity<User>().Property(p => p.Password).IsRequired();
            builder.Entity<User>().HasMany(p => p.Siparisler);
            builder.Entity<User>().HasData
            (

                new User { Id = 1, Name = "Kamil", LastName = "Candan", UserName = "KamilCandan", Email = "KamilCandan@gmail.com", Password = "1234" },
                new User { Id = 2, Name = "Zamzam", LastName = "Kadeve", UserName = "ZamzamKadeve", Email = "ZamzamKadeve@gmail.com", Password = "4567" }
            );


            builder.Entity<UserRole>().HasKey(ur => new { ur.UserId, ur.RoleId });
        }
    }
}
