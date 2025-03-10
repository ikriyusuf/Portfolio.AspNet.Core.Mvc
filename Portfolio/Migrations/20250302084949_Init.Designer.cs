﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.Models;

#nullable disable

namespace Portfolio.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250302084949_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Institution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Certificates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "BTK AKADEMİ",
                            Name = "Veri Bilimi için Python ve Tensorflow"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "Coderspace",
                            Name = "Data Science & AI Day 2024"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "KOSGEB",
                            Name = "KOSGEB Girişimcilik Eğitimi"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "Miuul",
                            Name = "Microsoft Azure Fundamentals"
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "BTK Akademi",
                            Name = "Versiyon Kontrolleri Git ve Github"
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "Coderspace",
                            Name = "Agile Development Day"
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "Habitat Derneği",
                            Name = "Geleceğini Tasarla Projesi Dijital İçerik Üretimi Eğitimi"
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "BTK Akademi",
                            Name = "Google Flutter Mobil Uygulama Kursu"
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Institution = "Udemy",
                            Name = "Yazılım Test Uzmanlığı Eğitimi"
                        });
                });

            modelBuilder.Entity("Entities.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Entities.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Degree = "Lise - Sayısal",
                            EndDate = new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolName = "Cemal BOZKURT Anadolu Lisesi",
                            StartDate = new DateTime(2016, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Degree = "Bilgisayar Mühendisi",
                            SchoolName = "Selçuk Üniversitesi",
                            StartDate = new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Entities.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Responsibilities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Company = "Boyser Servis Hizmetleri",
                            EndDate = new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JobTitle = "Yazılım Stajyeri",
                            Responsibilities = "Python programlama dili ve görüntü işleme teknolojilerini kullanarak, kumaş makinesi ekranından kumaş boyutu ve adını otomatik olarak okuyan ve bu verileri bir dosyaya kaydeden bir sistem geliştirdim.\nSistem sayesinde manuel veri girişi ihtiyacını ortadan kaldırarak operasyonel verimliliği artırdım.",
                            StartDate = new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Company = "Petlas",
                            EndDate = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JobTitle = "Yazılım Stajyeri",
                            Responsibilities = "ASP.NET ve C# teknolojilerini kullanarak, makine durumlarını gerçek zamanlı olarak izleyen ve raporlayan bir web uygulaması geliştirdim.\nUygulama sayesinde operasyonel süreçlerdeki verimlilik artırıldı ve makine arızalarının önceden tespit edilmesi sağlandı.",
                            StartDate = new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Company = "KASKİ - Kayseri Büyükşehir Belediyesi",
                            JobTitle = "Uzun Dönem Yazılım Stajyeri",
                            Responsibilities = "KASKİ bünyesinde uzun dönem stajımı yürütmekteyim.",
                            StartDate = new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Entities.Models.Personal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AboutMe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GithubUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedInUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ProfilePic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("XUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AboutMe = "Merhaba, ben Yusuf İKRİ. Selçuk Üniversitesi’nde 4. sınıf öğrencisiyim ve şu anda yapay zeka, derin öğrenme, ASP.NET ve mobil geliştirme alanlarında kendimi sürekli olarak geliştirmeye çalışıyorum. Stajlarımda kazandığım deneyimler, teorik bilgimi pratikte uygulama fırsatı sundu. Boyser Servis Hizmetler'de Python kullanarak kumaş makinelerinden alınan verileri işleyen bir sistem geliştirdim. Ardından, Petlas'ta ASP.NET ve C# ile makine durumlarını izleyen bir web uygulaması oluşturarak operasyonel veriler sağladım. Şu anda ise KASKİ - Kayseri Büyükşehir Belediyesi'nde uzun dönem stajı yapıyorum. Hedefim, bu süreçte kazandığım deneyimleri daha ileriye taşıyarak yazılım geliştirme alanında güçlü bir kariyer inşa etmek.",
                            Bio = "Teknolojiye tutkulu bir yazılım geliştiricisi olarak, sürekli öğrenmeye ve yenilikçi çözümler üretmeye odaklanıyorum. Yapay zeka, derin öğrenme ve ASP.NET gibi alanlarda kendimi geliştiriyor ve pratik deneyimlerle büyüyorum.",
                            Email = "yusufikri008@gmail.com",
                            GithubUrl = "https://github.com/ikriyusuf",
                            InstagramUrl = "https://www.instagram.com/ikriyusuf/",
                            Job = "Bilgisayar Mühendisi",
                            LinkedInUrl = "https://www.linkedin.com/in/yusufikri/",
                            Location = "Kayseri, Türkiye",
                            Name = "Yusuf İKRİ",
                            ProfilePic = "/images/propic.jpg",
                            Website = "ikriyusuf.com",
                            XUrl = "https://x.com/ikriyusuf"
                        });
                });

            modelBuilder.Entity("Entities.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technologies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Python kullanarak kumaş makinesi ekranından kumaş boyutu ve adını alıp bir dosyaya kaydeden bir sistem geliştirdim. Görüntü işleme teknikleriyle ekrandan verileri dinamik olarak çıkardım ve doğru biçimde saklanmasını sağladım.",
                            Technologies = "Python, OpenCV, Tesseract OCR",
                            Title = "Kumaş Boyutu ve Adı Okuma Sistemi"
                        },
                        new
                        {
                            Id = 2,
                            Description = "ASP.NET ve C# kullanarak makine durumlarını izleyen bir web uygulaması geliştirdim. Uygulama üzerinden makinelerin durumlarını izleyerek operasyonel veriler sağladım.",
                            Technologies = "ASP.NET, C#, MSSQL",
                            Title = "Makine Durum Takip Sistemi"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Makine öğrenimi modeli kullanarak laptop fiyat tahmini yapan bir sistem geliştirdim. Fiyat tahmini için verileri işleyip modeli eğittim.",
                            Technologies = "Python, Scikit-Learn, Pandas, NumPy",
                            Title = "Laptop Fiyat Tahmini"
                        },
                        new
                        {
                            Id = 4,
                            Description = "YOLOv8 kullanarak deri hastalıklarını tespit eden bir derin öğrenme modeli geliştirdim. Flutter ile mobil uygulama oluşturarak, çekilen fotoğrafları Flask API'ye gönderip tahmin sonuçlarını aldım.",
                            Technologies = "YOLOv8, Python, Flask, Flutter, TensorFlow",
                            Title = "Deri Hastalıkları Tahmini"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Sağlık ocağı randevu ve hasta takibini sağlayan bir sistem geliştirdim. MSSQL kullanarak veritabanı işlemlerini yönettim.",
                            Technologies = "C#, MSSQL",
                            Title = "Sağlık Ocağı Takip Sistemi"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "9afc3dc8-f6a0-4cf5-97cd-0309cbaae65c",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
