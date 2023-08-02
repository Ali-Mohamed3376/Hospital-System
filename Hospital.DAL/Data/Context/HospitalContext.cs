using Hospital.DAL.Data.Models;
using Hospital.DAL.Migrations;
using Microsoft.EntityFrameworkCore;
namespace Hospital.DAL.Data.Context
{
    public class HospitalContext : DbContext
    {
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Issue> Issues => Set<Issue>();
        public HospitalContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Seeding Docs
            var doctors = new List<Doctor>()
            {
                  new Doctor {
                    Id= Guid.NewGuid(),
                    Name= "Jessie",
                    Specialization= "Hematology",
                    Salary= 27064,
                    PerofrmancRate= 65,
                  },
                  new Doctor {
                    Id= Guid.NewGuid(),
                    Name= "Judy",
                    Specialization= "Neurology",
                    Salary= 18711,
                    PerofrmancRate= 32,
                  },
                  new Doctor {
                    Id= Guid.NewGuid(),
                    Name= "Naomi",
                    Specialization= "Pediatrics",
                    Salary= 32145,
                    PerofrmancRate= 27,
                  },
                  new Doctor {
                    Id= Guid.NewGuid(),
                    Name= "Joann",
                    Specialization= "Hematology",
                    Salary= 9232,
                    PerofrmancRate= 72,
                  },
                  new Doctor {
                    Id= Guid.NewGuid(),
                    Name= "Judy",
                    Specialization= "Dermatology",
                    Salary= 48498,
                    PerofrmancRate= 19,
                  },
                  new Doctor {
                    Id= Guid.NewGuid(),
                    Name= "Alyssa",
                    Specialization= "Gastroenterology",
                    Salary= 16586,
                    PerofrmancRate= 79,
                  },
                  new Doctor {
                    Id= Guid.NewGuid(),
                    Name= "Mable",
                    Specialization= "Infectious Disease",
                    Salary= 33706,
                    PerofrmancRate= 5,
                  },
                  new Doctor {
                    Id= Guid.NewGuid(),
                    Name= "Paula",
                    Specialization= "Urology",
                    Salary= 19094,
                    PerofrmancRate= 0,
                  },
                  new Doctor {
                    Id= Guid.NewGuid(),
                    Name= "Rafael",
                    Specialization= "Pediatrics",
                    Salary= 12266,
                    PerofrmancRate= 97,
                  },
                  new Doctor {
                    Id= Guid.NewGuid(),
                    Name= "Sara",
                    Specialization= "Pediatrics",
                    Salary= 45041,
                    PerofrmancRate= 82,
                  },
            };
            #endregion

            #region Patients
            var patients = new List<Patient>
                {
                  new Patient { Id= Guid.NewGuid(), Name= "Dana", DoctorId=doctors[5].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Isaac", DoctorId=doctors[7].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Damon", DoctorId=doctors[9].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Miriam", DoctorId=doctors[8].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Terence", DoctorId=doctors[7].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Roosevelt", DoctorId=doctors[1].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Eduardo", DoctorId=doctors[9].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Wilbert", DoctorId=doctors[8].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Tasha", DoctorId=doctors[5].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Max", DoctorId=doctors[1].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Bridget", DoctorId=doctors[2].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Juan", DoctorId=doctors[8].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Krystal", DoctorId=doctors[0].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Erma", DoctorId=doctors[0].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Orlando", DoctorId=doctors[6].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Marvin", DoctorId=doctors[5].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Lamar", DoctorId=doctors[4].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Joe", DoctorId=doctors[7].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Wendell", DoctorId=doctors[8].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Sandra", DoctorId=doctors[4].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Stephanie", DoctorId=doctors[6].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Ervin", DoctorId=doctors[7].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Beth", DoctorId=doctors[4].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Gretchen", DoctorId=doctors[7].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Gwendolyn", DoctorId=doctors[2].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Jerry", DoctorId=doctors[7].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Mitchell", DoctorId=doctors[6].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Maggie", DoctorId=doctors[8].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Sandy", DoctorId=doctors[3].Id},
                  new Patient { Id= Guid.NewGuid(), Name= "Lloyd", DoctorId=doctors[2].Id}
        };
            #endregion

            #region Issues

            var issues = new List<Issue>
                {
                  new Issue { Id= Guid.NewGuid(), Name= "Diabetes" },
                  new Issue { Id= Guid.NewGuid(), Name= "Hypertension" },
                  new Issue { Id= Guid.NewGuid(), Name= "Asthma" },
                  new Issue { Id= Guid.NewGuid(), Name= "Depression" },
                  new Issue { Id= Guid.NewGuid(), Name= "Arthritis" },
                  new Issue { Id= Guid.NewGuid(), Name= "Allergy" },
                  new Issue { Id= Guid.NewGuid(), Name= "Flu" },
                };

            #endregion



            modelBuilder.Entity<Patient>().HasData(patients);
            modelBuilder.Entity<Issue>().HasData(issues);
            modelBuilder.Entity<Doctor>().HasData(doctors);
        }
    }
}
