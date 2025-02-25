using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasData(
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
        }
    }
}
