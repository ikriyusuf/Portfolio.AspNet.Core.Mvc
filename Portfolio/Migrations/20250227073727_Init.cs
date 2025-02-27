using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Institution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SchoolName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Responsibilities = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutMe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkedInUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GithubUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Technologies = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9afc3dc8-f6a0-4cf5-97cd-0309cbaae65c", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "Date", "Institution", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTK AKADEMİ", "Veri Bilimi için Python ve Tensorflow" },
                    { 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coderspace", "Data Science & AI Day 2024" },
                    { 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KOSGEB", "KOSGEB Girişimcilik Eğitimi" },
                    { 4, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miuul", "Microsoft Azure Fundamentals" },
                    { 5, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTK Akademi", "Versiyon Kontrolleri Git ve Github" },
                    { 6, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coderspace", "Agile Development Day" },
                    { 7, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Habitat Derneği", "Geleceğini Tasarla Projesi Dijital İçerik Üretimi Eğitimi" },
                    { 8, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTK Akademi", "Google Flutter Mobil Uygulama Kursu" },
                    { 9, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Udemy", "Yazılım Test Uzmanlığı Eğitimi" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Degree", "EndDate", "SchoolName", "StartDate" },
                values: new object[,]
                {
                    { 1, "Lise - Sayısal", new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cemal BOZKURT Anadolu Lisesi", new DateTime(2016, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Bilgisayar Mühendisi", null, "Selçuk Üniversitesi", new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Company", "EndDate", "JobTitle", "Responsibilities", "StartDate" },
                values: new object[,]
                {
                    { 1, "Boyser Servis Hizmetleri", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yazılım Stajyeri", "Python programlama dili ve görüntü işleme teknolojilerini kullanarak, kumaş makinesi ekranından kumaş boyutu ve adını otomatik olarak okuyan ve bu verileri bir dosyaya kaydeden bir sistem geliştirdim.\nSistem sayesinde manuel veri girişi ihtiyacını ortadan kaldırarak operasyonel verimliliği artırdım.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Petlas", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yazılım Stajyeri", "ASP.NET ve C# teknolojilerini kullanarak, makine durumlarını gerçek zamanlı olarak izleyen ve raporlayan bir web uygulaması geliştirdim.\nUygulama sayesinde operasyonel süreçlerdeki verimlilik artırıldı ve makine arızalarının önceden tespit edilmesi sağlandı.", new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "KASKİ - Kayseri Büyükşehir Belediyesi", null, "Uzun Dönem Yazılım Stajyeri", "KASKİ bünyesinde uzun dönem stajımı yürütmekteyim.", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Personals",
                columns: new[] { "Id", "AboutMe", "Bio", "Email", "GithubUrl", "InstagramUrl", "Job", "LinkedInUrl", "Location", "Name", "ProfilePic", "Website", "XUrl" },
                values: new object[] { 1, "Merhaba, ben Yusuf İKRİ. Selçuk Üniversitesi’nde 4. sınıf öğrencisiyim ve şu anda yapay zeka, derin öğrenme, ASP.NET ve mobil geliştirme alanlarında kendimi sürekli olarak geliştirmeye çalışıyorum. Stajlarımda kazandığım deneyimler, teorik bilgimi pratikte uygulama fırsatı sundu. Boyser Servis Hizmetler'de Python kullanarak kumaş makinelerinden alınan verileri işleyen bir sistem geliştirdim. Ardından, Petlas'ta ASP.NET ve C# ile makine durumlarını izleyen bir web uygulaması oluşturarak operasyonel veriler sağladım. Şu anda ise KASKİ - Kayseri Büyükşehir Belediyesi'nde uzun dönem stajı yapıyorum. Hedefim, bu süreçte kazandığım deneyimleri daha ileriye taşıyarak yazılım geliştirme alanında güçlü bir kariyer inşa etmek.", "Teknolojiye tutkulu bir yazılım geliştiricisi olarak, sürekli öğrenmeye ve yenilikçi çözümler üretmeye odaklanıyorum. Yapay zeka, derin öğrenme ve ASP.NET gibi alanlarda kendimi geliştiriyor ve pratik deneyimlerle büyüyorum.", "yusufikri008@gmail.com", "https://github.com/ikriyusuf", "https://www.instagram.com/ikriyusuf/", "Bilgisayar Mühendisi", "https://www.linkedin.com/in/yusufikri/", "Kayseri, Türkiye", "Yusuf İKRİ", "/images/propic.jpg", "ikriyusuf.com", "https://x.com/ikriyusuf" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "Technologies", "Title" },
                values: new object[,]
                {
                    { 1, "Python kullanarak kumaş makinesi ekranından kumaş boyutu ve adını alıp bir dosyaya kaydeden bir sistem geliştirdim. Görüntü işleme teknikleriyle ekrandan verileri dinamik olarak çıkardım ve doğru biçimde saklanmasını sağladım.", "Python, OpenCV, Tesseract OCR", "Kumaş Boyutu ve Adı Okuma Sistemi" },
                    { 2, "ASP.NET ve C# kullanarak makine durumlarını izleyen bir web uygulaması geliştirdim. Uygulama üzerinden makinelerin durumlarını izleyerek operasyonel veriler sağladım.", "ASP.NET, C#, MSSQL", "Makine Durum Takip Sistemi" },
                    { 3, "Makine öğrenimi modeli kullanarak laptop fiyat tahmini yapan bir sistem geliştirdim. Fiyat tahmini için verileri işleyip modeli eğittim.", "Python, Scikit-Learn, Pandas, NumPy", "Laptop Fiyat Tahmini" },
                    { 4, "YOLOv8 kullanarak deri hastalıklarını tespit eden bir derin öğrenme modeli geliştirdim. Flutter ile mobil uygulama oluşturarak, çekilen fotoğrafları Flask API'ye gönderip tahmin sonuçlarını aldım.", "YOLOv8, Python, Flask, Flutter, TensorFlow", "Deri Hastalıkları Tahmini" },
                    { 5, "Sağlık ocağı randevu ve hasta takibini sağlayan bir sistem geliştirdim. MSSQL kullanarak veritabanı işlemlerini yönettim.", "C#, MSSQL", "Sağlık Ocağı Takip Sistemi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Personals");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
