using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Personal> Personals { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Certificate> Certificates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Personal Entity için Seed Data
            modelBuilder.Entity<Personal>().HasData(
                new Personal()
                {
                    Id = 1,
                    Email = "yusufikri008@gmail.com",
                    Location = "Kayseri, Türkiye",
                    Job = "Bilgisayar Mühendisi",
                    ProfilePic = "/images/propic.jpg",
                    LinkedInUrl = "https://www.linkedin.com/in/yusufikri/",
                    InstagramUrl = "https://www.instagram.com/ikriyusuf/",
                    GithubUrl = "https://github.com/ikriyusuf",
                    XUrl = "https://x.com/ikriyusuf",
                    Name = "Yusuf İKRİ",
                    Website = "ikriyusuf.com",
                    Bio = "Teknolojiye tutkulu bir yazılım geliştiricisi olarak, sürekli öğrenmeye ve yenilikçi çözümler üretmeye odaklanıyorum. Yapay zeka, derin öğrenme ve ASP.NET gibi alanlarda kendimi geliştiriyor ve pratik deneyimlerle büyüyorum.",
                    AboutMe = "Merhaba, ben Yusuf İKRİ. Selçuk Üniversitesi’nde 4. sınıf öğrencisiyim ve şu anda yapay zeka, derin öğrenme, ASP.NET ve mobil geliştirme alanlarında kendimi sürekli olarak geliştirmeye çalışıyorum. Stajlarımda kazandığım deneyimler, teorik bilgimi pratikte uygulama fırsatı sundu. Boyser Servis Hizmetler'de Python kullanarak kumaş makinelerinden alınan verileri işleyen bir sistem geliştirdim. Ardından, Petlas'ta ASP.NET ve C# ile makine durumlarını izleyen bir web uygulaması oluşturarak operasyonel veriler sağladım. Şu anda ise KASKİ - Kayseri Büyükşehir Belediyesi'nde uzun dönem stajı yapıyorum. Hedefim, bu süreçte kazandığım deneyimleri daha ileriye taşıyarak yazılım geliştirme alanında güçlü bir kariyer inşa etmek."
                }
            );

            // Project Entity için Seed Data
            modelBuilder.Entity<Project>().HasData(
                new Project()
                {
                    Id = 1,
                    Description = "Python kullanarak kumaş makinesi ekranından kumaş boyutu ve adını alıp bir dosyaya kaydeden bir sistem geliştirdim. Görüntü işleme teknikleriyle ekrandan verileri dinamik olarak çıkardım ve doğru biçimde saklanmasını sağladım.",
                    Technologies = "Python, OpenCV, Tesseract OCR",
                    Title = "Kumaş Boyutu ve Adı Okuma Sistemi",
                },
                new Project()
                {
                    Id = 2,
                    Description = "ASP.NET ve C# kullanarak makine durumlarını izleyen bir web uygulaması geliştirdim. Uygulama üzerinden makinelerin durumlarını izleyerek operasyonel veriler sağladım.",
                    Technologies = "ASP.NET, C#, MSSQL",
                    Title = "Makine Durum Takip Sistemi",
                },
                new Project()
                {
                    Id = 3,
                    Description = "Makine öğrenimi modeli kullanarak laptop fiyat tahmini yapan bir sistem geliştirdim. Fiyat tahmini için verileri işleyip modeli eğittim.",
                    Technologies = "Python, Scikit-Learn, Pandas, NumPy",
                    Title = "Laptop Fiyat Tahmini",
                },
                new Project()
                {
                    Id = 4,
                    Description = "YOLOv8 kullanarak deri hastalıklarını tespit eden bir derin öğrenme modeli geliştirdim. Flutter ile mobil uygulama oluşturarak, çekilen fotoğrafları Flask API'ye gönderip tahmin sonuçlarını aldım.",
                    Technologies = "YOLOv8, Python, Flask, Flutter, TensorFlow",
                    Title = "Deri Hastalıkları Tahmini",
                },
                new Project()
                {
                    Id = 5,
                    Description = "Sağlık ocağı randevu ve hasta takibini sağlayan bir sistem geliştirdim. MSSQL kullanarak veritabanı işlemlerini yönettim.",
                    Technologies = "C#, MSSQL",
                    Title = "Sağlık Ocağı Takip Sistemi",
                }
            );

            // Experience Entity için Seed Data
            modelBuilder.Entity<Experience>().HasData(
                new Experience()
                {
                    Id = 1,
                    JobTitle = "Yazılım Stajyeri",
                    Company = "Boyser Servis Hizmetleri",
                    StartDate = new DateTime(2024, 7, 1),
                    EndDate = new DateTime(2024, 7, 24),
                    Responsibilities = "Python programlama dili ve görüntü işleme teknolojilerini kullanarak, kumaş makinesi ekranından kumaş boyutu ve adını otomatik olarak okuyan ve bu verileri bir dosyaya kaydeden bir sistem geliştirdim.\n" +
                                       "Sistem sayesinde manuel veri girişi ihtiyacını ortadan kaldırarak operasyonel verimliliği artırdım."
                },
                new Experience()
                {
                    Id = 2,
                    JobTitle = "Yazılım Stajyeri",
                    Company = "Petlas",
                    StartDate = new DateTime(2024, 8, 5),
                    EndDate = new DateTime(2024, 9, 2),
                    Responsibilities = "ASP.NET ve C# teknolojilerini kullanarak, makine durumlarını gerçek zamanlı olarak izleyen ve raporlayan bir web uygulaması geliştirdim.\n" +
                                       "Uygulama sayesinde operasyonel süreçlerdeki verimlilik artırıldı ve makine arızalarının önceden tespit edilmesi sağlandı."
                },
                new Experience()
                {
                    Id = 3,
                    JobTitle = "Uzun Dönem Yazılım Stajyeri",
                    Company = "KASKİ - Kayseri Büyükşehir Belediyesi",
                    StartDate = new DateTime(2024, 7, 25),
                    EndDate = null,
                    Responsibilities = "KASKİ bünyesinde uzun dönem stajımı yürütmekteyim."
                }
            );
            modelBuilder.Entity<Education>().HasData(
    new Education()
    {
        Id = 1,
        Degree = "Lise - Sayısal",
        SchoolName = "Cemal BOZKURT Anadolu Lisesi",
        StartDate = new DateTime(2016, 9, 19),
        EndDate = new DateTime(2020, 6, 19),
    },
    new Education()
    {
        Id = 2,
        Degree = "Bilgisayar Mühendisi",
        SchoolName = "Selçuk Üniversitesi",
        StartDate = new DateTime(2021, 9, 5),
        EndDate = null,
    }
);
            modelBuilder.Entity<Certificate>().HasData(
    new Certificate()
    {
        Id = 1,
        Name= "Veri Bilimi için Python ve Tensorflow",
        Institution="BTK AKADEMİ",
        Date= new DateTime(2025, 1, 1)
    },
       new Certificate()
       {
           Id = 2,
           Name = "Data Science & AI Day 2024",
           Institution = "Coderspace",
           Date = new DateTime(2024, 9, 1)
       },
       new Certificate()
       {
           Id = 3,
           Name = "KOSGEB Girişimcilik Eğitimi",
           Institution = "KOSGEB",
           Date = new DateTime(2024, 9, 1)
       },
       new Certificate()
       {
           Id = 4,
           Name = "Microsoft Azure Fundamentals",
           Institution = "Miuul",
           Date = new DateTime(2024, 9, 1)
       },
        new Certificate()
        {
            Id = 5,
            Name = "Versiyon Kontrolleri Git ve Github",
            Institution = "BTK Akademi",
            Date = new DateTime(2024, 9, 1)
        },
         new Certificate()
         {
             Id = 6,
             Name = "Agile Development Day",
             Institution = "Coderspace",
             Date = new DateTime(2023, 5, 1)
         },
         new Certificate()
         {
             Id = 7,
             Name = "Geleceğini Tasarla Projesi Dijital İçerik Üretimi Eğitimi",
             Institution = "Habitat Derneği",
             Date = new DateTime(2023, 6, 1)
         },
         new Certificate()
         {
             Id = 8,
             Name = "Google Flutter Mobil Uygulama Kursu",
             Institution = "BTK Akademi",
             Date = new DateTime(2023, 7, 1)
         },
          new Certificate()
          {
              Id = 9,
              Name = "Yazılım Test Uzmanlığı Eğitimi",
              Institution = "Udemy",
              Date = new DateTime(2023, 8, 1)
          }
);
        }
    }
}