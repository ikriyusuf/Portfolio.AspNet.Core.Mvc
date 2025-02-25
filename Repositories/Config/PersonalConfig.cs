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
    public class PersonalConfig : IEntityTypeConfiguration<Personal>
    {
        public void Configure(EntityTypeBuilder<Personal> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Email).IsRequired();
            builder.HasData(
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
        }
    }
}
