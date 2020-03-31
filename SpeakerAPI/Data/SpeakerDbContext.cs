using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpeakerLibrary;

namespace SpeakerAPI.Data
{
    public class SpeakerDbContext : DbContext
    {
        public DbSet<Speaker> Speakers { get; set; }

        public SpeakerDbContext(DbContextOptions<SpeakerDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Speaker>().HasData(
              new
              {
                  SpeakerId = Guid.NewGuid().ToString(),
                  FirstName = "John",
                  LastName = "Doe",
                  Email = "jdoe@gmail.com",
                  MobileNumber = "604-123-4567",
                  Specialization = "JavaScript",
                  City = "Vancouver",
                  Province = "BC",
                  Employer = "UBC"
              }, new
              {
                  SpeakerId = Guid.NewGuid().ToString(),
                  FirstName = "Phil",
                  LastName = "Weier",
                  Email = "pweier@gmail.com",
                  MobileNumber = "604-987-6543",
                  Specialization = ".NET",
                  City = "Maple Ridge",
                  Province = "BC",
                  Employer = "BCIT"
              }, new
              {
                  SpeakerId = Guid.NewGuid().ToString(),
                  FirstName = "Jason",
                  LastName = "Harrison",
                  Email = "jharrison@gmail.com",
                  MobileNumber = "604-111-1111",
                  Specialization = "Laravel",
                  City = "Vancouver",
                  Province = "BC",
                  Employer = "SFU"
              }, new
              {
                  SpeakerId = Guid.NewGuid().ToString(),
                  FirstName = "Alex",
                  LastName = "Cooper",
                  Email = "acooper@gmail.com",
                  MobileNumber = "604-212-2121",
                  Specialization = "HTML/CSS",
                  City = "Chilliwack",
                  Province = "BC",
                  Employer = "BCIT"
              }
            );
        }
    }
}
