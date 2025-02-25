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
    public class CertificateConfig : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.HasData(
                  new Certificate()
                  {
                      Id = 1,
                      Name = "Veri Bilimi için Python ve Tensorflow",
                      Institution = "BTK AKADEMİ",
                      Date = new DateTime(2025, 1, 1)
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
          });
        }
    }
}
