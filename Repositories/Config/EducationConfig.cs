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
    public class EducationConfig : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasData(
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
        }
    }
}
