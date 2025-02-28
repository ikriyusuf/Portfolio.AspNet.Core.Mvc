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
    public class ExperienceConfig : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.HasData(
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
                    StartDate = new DateTime(2025, 2, 10),
                    EndDate = null,
                    Responsibilities = "KASKİ bünyesinde uzun dönem stajımı yürütmekteyim."
                }
                );
        }
    }
}
