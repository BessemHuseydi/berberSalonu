using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WEB.Models
{
    public class BerberContext:DbContext
    {
        // Constructor
        public BerberContext(DbContextOptions<BerberContext> options) : base(options)
        {
        }
        public DbSet<Hizmet> Hizmetler { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<CalismaSaati> CalismaSaatleri { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var passwordHasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Ahmet Yılmaz", Phone = "05331234567", Email = "ahmet.yilmaz@gmail.com", PasswordHash = passwordHasher.HashPassword(null, "Ahmet123!") },
                new User { Id = 2, Name = "Ayşe Demir", Phone = "05339876543", Email = "ayse.demir@gmail.com", PasswordHash = passwordHasher.HashPassword(null, "Ayse123!") },
                new User { Id = 3, Name = "Fatma Çelik", Phone = "05431234567", Email = "fatma.celik@gmail.com", PasswordHash = passwordHasher.HashPassword(null, "Fatma123!") },
                new User { Id = 4, Name = "Mehmet Kara", Phone = "05439876543", Email = "mehmet.kara@gmail.com", PasswordHash = passwordHasher.HashPassword(null, "Mehmet123!") },
                new User { Id = 5, Name = "Ali Can", Phone = "05551234567", Email = "ali.can@gmail.com", PasswordHash = passwordHasher.HashPassword(null, "Ali123!") },
                new User { Id = 6, Name = "Merve Şen", Phone = "05631234567", Email = "merve.sen@gmail.com", PasswordHash = passwordHasher.HashPassword(null, "Merve123!") },
                new User { Id = 7, Name = "Burak Arslan", Phone = "05471234567", Email = "burak.arslan@gmail.com", PasswordHash = passwordHasher.HashPassword(null, "Burak123!") },
                new User { Id = 8, Name = "Emre Yıldız", Phone = "05381234567", Email = "emre.yildiz@gmail.com", PasswordHash = passwordHasher.HashPassword(null, "Emre123!") },
                new User { Id = 9, Name = "Elif Gül", Phone = "05569876543", Email = "elif.gul@gmail.com", PasswordHash = passwordHasher.HashPassword(null, "Elif123!") },
                new User { Id = 10, Name = "Hüseyin Demir", Phone = "05351239876", Email = "huseyin.demir@gmail.com", PasswordHash = passwordHasher.HashPassword(null, "Huseyin123!") }
            );

            modelBuilder.Entity<Hizmet>().HasData(
            new Hizmet { Id = 1, Name = "Saç Kesimi", DurationMinutes = 30, Price = 50 },
            new Hizmet { Id = 2, Name = "Manikür", DurationMinutes = 45, Price = 80 },
            new Hizmet { Id = 3, Name = "Pedikür", DurationMinutes = 60, Price = 100 },
            new Hizmet { Id = 4, Name = "Saç Boyama", DurationMinutes = 90, Price = 200 },
            new Hizmet { Id = 5, Name = "Cilt Bakımı", DurationMinutes = 120, Price = 150 },
            new Hizmet { Id = 6, Name = "Sakal Kesimi", DurationMinutes = 25, Price = 40 },
            new Hizmet { Id = 7, Name = "Masaj", DurationMinutes = 60, Price = 250 },
            new Hizmet { Id = 8, Name = "Saç Yıkama", DurationMinutes = 15, Price = 20 },
            new Hizmet { Id = 9, Name = "Yüz Temizleme", DurationMinutes = 30, Price = 100 },
            new Hizmet { Id = 10, Name = "Bıyık Şekillendirme", DurationMinutes = 20, Price = 30 }
            );
            modelBuilder.Entity<Salon>().HasData(
            new Salon { Id = 1, Name = "Elite Güzellik Salonu", Location = "İstanbul", ContactNumber = "02124567890" },
            new Salon { Id = 2, Name = "Lüks Kuaför", Location = "Ankara", ContactNumber = "03124567890" },
            new Salon { Id = 3, Name = "Güzellik Merkezi", Location = "İzmir", ContactNumber = "02324567890" },
            new Salon { Id = 4, Name = "Bakım ve Spa", Location = "Antalya", ContactNumber = "02424567890" },
            new Salon { Id = 5, Name = "Zen Saç Stüdyosu", Location = "Bursa", ContactNumber = "02224567890" },
            new Salon { Id = 6, Name = "Royal Saç Merkezi", Location = "Adana", ContactNumber = "03224567890" },
            new Salon { Id = 7, Name = "Luxury Hair", Location = "Gaziantep", ContactNumber = "03424567890" },
            new Salon { Id = 8, Name = "Dream Spa", Location = "Kayseri", ContactNumber = "03524567890" },
            new Salon { Id = 9, Name = "Modern Güzellik", Location = "Eskişehir", ContactNumber = "02224567891" },
            new Salon { Id = 10, Name = "Prestij Bakım Merkezi", Location = "Konya", ContactNumber = "03324567890" }
            );
            modelBuilder.Entity<Calisan>().HasData(
     // Salon 1
     new Calisan { Id = 1, Name = "Zeynep Aydın", SalonId = 1, Position = "Kuaför", ExperienceYears = 5 },
     new Calisan { Id = 2, Name = "Ali Yılmaz", SalonId = 1, Position = "Berber", ExperienceYears = 6 },
     new Calisan { Id = 3, Name = "Selin Arslan", SalonId = 1, Position = "Saç Stilisti", ExperienceYears = 4 },
     new Calisan { Id = 4, Name = "Ayşe Demir", SalonId = 1, Position = "Makyaj Uzmanı", ExperienceYears = 3 },
     new Calisan { Id = 5, Name = "Mehmet Kaya", SalonId = 1, Position = "Masaj Terapisti", ExperienceYears = 7 },

     // Salon 2
     new Calisan { Id = 6, Name = "Hülya Akın", SalonId = 2, Position = "Manikürist", ExperienceYears = 3 },
     new Calisan { Id = 7, Name = "Fatma Çelik", SalonId = 2, Position = "Pedikürist", ExperienceYears = 5 },
     new Calisan { Id = 8, Name = "Ahmet Şen", SalonId = 2, Position = "Berber", ExperienceYears = 8 },
     new Calisan { Id = 9, Name = "Burcu Arslan", SalonId = 2, Position = "Cilt Bakım Uzmanı", ExperienceYears = 6 },

     // Salon 3
     new Calisan { Id = 10, Name = "Burak Şen", SalonId = 3, Position = "Pedikürist", ExperienceYears = 4 },
     new Calisan { Id = 11, Name = "Selim Kaya", SalonId = 3, Position = "Saç Stilisti", ExperienceYears = 7 },
     new Calisan { Id = 12, Name = "Buse Güneş", SalonId = 3, Position = "Kuaför", ExperienceYears = 2 },
     new Calisan { Id = 13, Name = "Kemal Demir", SalonId = 3, Position = "Berber", ExperienceYears = 6 },
     new Calisan { Id = 14, Name = "Aycan Yıldız", SalonId = 3, Position = "Makyaj Uzmanı", ExperienceYears = 3 },

     // Salon 4
     new Calisan { Id = 15, Name = "Elif Güneş", SalonId = 4, Position = "Cilt Bakım Uzmanı", ExperienceYears = 6 },
     new Calisan { Id = 16, Name = "Hasan Çelik", SalonId = 4, Position = "Masaj Terapisti", ExperienceYears = 8 },
     new Calisan { Id = 17, Name = "Fatih Arslan", SalonId = 4, Position = "Berber", ExperienceYears = 5 },
     new Calisan { Id = 18, Name = "Burcu Kaya", SalonId = 4, Position = "Kuaför", ExperienceYears = 4 },
     new Calisan { Id = 19, Name = "Zehra Şahin", SalonId = 4, Position = "Makyaj Uzmanı", ExperienceYears = 3 },

     // Salon 5
     new Calisan { Id = 20, Name = "Selim Kaya", SalonId = 5, Position = "Saç Stilisti", ExperienceYears = 7 },
     new Calisan { Id = 21, Name = "Merve Şen", SalonId = 5, Position = "Manikürist", ExperienceYears = 3 },
     new Calisan { Id = 22, Name = "Ahmet Çelik", SalonId = 5, Position = "Berber", ExperienceYears = 8 },
     new Calisan { Id = 23, Name = "Fatma Yıldız", SalonId = 5, Position = "Pedikürist", ExperienceYears = 5 },

     // Salon 6
     new Calisan { Id = 24, Name = "Kemal Yılmaz", SalonId = 6, Position = "Berber", ExperienceYears = 8 },
     new Calisan { Id = 25, Name = "Zehra Akın", SalonId = 6, Position = "Kuaför", ExperienceYears = 6 },
     new Calisan { Id = 26, Name = "Aycan Arslan", SalonId = 6, Position = "Makyaj Uzmanı", ExperienceYears = 4 },
     new Calisan { Id = 27, Name = "Emre Şen", SalonId = 6, Position = "Masaj Terapisti", ExperienceYears = 7 },

     // Salon 7
     new Calisan { Id = 28, Name = "Merve Şen", SalonId = 7, Position = "Makyaj Uzmanı", ExperienceYears = 4 },
     new Calisan { Id = 29, Name = "Fatih Çelik", SalonId = 7, Position = "Masaj Terapisti", ExperienceYears = 5 },
     new Calisan { Id = 30, Name = "Büşra Arslan", SalonId = 7, Position = "Kuaför", ExperienceYears = 6 },
     new Calisan { Id = 31, Name = "Hasan Kaya", SalonId = 7, Position = "Berber", ExperienceYears = 9 },

     // Salon 8
     new Calisan { Id = 32, Name = "Fatih Çelik", SalonId = 8, Position = "Masaj Terapisti", ExperienceYears = 5 },
     new Calisan { Id = 33, Name = "Burcu Yıldız", SalonId = 8, Position = "Kuaför", ExperienceYears = 4 },
     new Calisan { Id = 34, Name = "Emre Kaya", SalonId = 8, Position = "Berber", ExperienceYears = 7 },
     new Calisan { Id = 35, Name = "Selin Şen", SalonId = 8, Position = "Makyaj Uzmanı", ExperienceYears = 3 },

     // Salon 9
     new Calisan { Id = 36, Name = "Ahmet Arslan", SalonId = 9, Position = "Berber", ExperienceYears = 10 },
     new Calisan { Id = 37, Name = "Zehra Demir", SalonId = 9, Position = "Kuaför", ExperienceYears = 5 },
     new Calisan { Id = 38, Name = "Kemal Şahin", SalonId = 9, Position = "Masaj Terapisti", ExperienceYears = 7 },
     new Calisan { Id = 39, Name = "Fatma Çelik", SalonId = 9, Position = "Makyaj Uzmanı", ExperienceYears = 4 },

     // Salon 10
     new Calisan { Id = 40, Name = "Ayşe Can", SalonId = 10, Position = "Manikürist", ExperienceYears = 2 },
     new Calisan { Id = 41, Name = "Selim Kaya", SalonId = 10, Position = "Saç Stilisti", ExperienceYears = 7 },
     new Calisan { Id = 42, Name = "Hasan Şen", SalonId = 10, Position = "Berber", ExperienceYears = 8 },
     new Calisan { Id = 43, Name = "Büşra Çelik", SalonId = 10, Position = "Makyaj Uzmanı", ExperienceYears = 3 }
 );
            modelBuilder.Entity<Randevu>().HasData(
            new Randevu { Id = 1, UserId = 1, SalonId = 1, AppointmentTime = new DateTime(2024, 12, 13, 14, 0, 0), Service = "Saç Kesimi", Price = 50 },
            new Randevu { Id = 2, UserId = 2, SalonId = 2, AppointmentTime = new DateTime(2024, 12, 14, 15, 0, 0), Service = "Manikür", Price = 80 },
            new Randevu { Id = 3, UserId = 3, SalonId = 3, AppointmentTime = new DateTime(2024, 12, 15, 16, 0, 0), Service = "Pedikür", Price = 100 },
            new Randevu { Id = 4, UserId = 4, SalonId = 4, AppointmentTime = new DateTime(2024, 12, 16, 11, 0, 0), Service = "Cilt Bakımı", Price = 150 },
            new Randevu { Id = 5, UserId = 5, SalonId = 5, AppointmentTime = new DateTime(2024, 12, 17, 13, 0, 0), Service = "Saç Boyama", Price = 200 },
            new Randevu { Id = 6, UserId = 6, SalonId = 6, AppointmentTime = new DateTime(2024, 12, 18, 10, 0, 0), Service = "Sakal Kesimi", Price = 40 },
            new Randevu { Id = 7, UserId = 7, SalonId = 7, AppointmentTime = new DateTime(2024, 12, 19, 12, 0, 0), Service = "Masaj", Price = 250 },
            new Randevu { Id = 8, UserId = 8, SalonId = 8, AppointmentTime = new DateTime(2024, 12, 20, 15, 0, 0), Service = "Yüz Temizleme", Price = 100 },
            new Randevu { Id = 9, UserId = 9, SalonId = 9, AppointmentTime = new DateTime(2024, 12, 21, 16, 0, 0), Service = "Saç Kesimi", Price = 50 },
            new Randevu { Id = 10, UserId = 10, SalonId = 10, AppointmentTime = new DateTime(2024, 12, 22, 14, 0, 0), Service = "Manikür", Price = 80 }
            );
            modelBuilder.Entity<CalismaSaati>().HasData(
                new CalismaSaati { Id = 1, CalisanId = 1, DayOfWeek = "Pazartesi", StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(18, 0, 0) },
                new CalismaSaati { Id = 2, CalisanId = 1, DayOfWeek = "Salı", StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(18, 0, 0) },
                new CalismaSaati { Id = 3, CalisanId = 1, DayOfWeek = "Çarşamba", StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(18, 0, 0) },
                new CalismaSaati { Id = 4, CalisanId = 1, DayOfWeek = "Perşembe", StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(18, 0, 0) },
                new CalismaSaati { Id = 5, CalisanId = 1, DayOfWeek = "Cuma", StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(18, 0, 0) },
                new CalismaSaati { Id = 6, CalisanId = 1, DayOfWeek = "Cumartesi", StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(16, 0, 0) },

                new CalismaSaati { Id = 7, CalisanId = 2, DayOfWeek = "Pazartesi", StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(19, 0, 0) },
                new CalismaSaati { Id = 8, CalisanId = 2, DayOfWeek = "Salı", StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(19, 0, 0) },
                new CalismaSaati { Id = 9, CalisanId = 2, DayOfWeek = "Çarşamba", StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(19, 0, 0) },
                new CalismaSaati { Id = 10, CalisanId = 2, DayOfWeek = "Perşembe", StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(19, 0, 0) },
                new CalismaSaati { Id = 11, CalisanId = 2, DayOfWeek = "Cuma", StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(19, 0, 0) },
                new CalismaSaati { Id = 12, CalisanId = 2, DayOfWeek = "Cumartesi", StartTime = new TimeSpan(10, 30, 0), EndTime = new TimeSpan(17, 0, 0) },

                // Diğer çalışanlar için devam edebilirsiniz.
                new CalismaSaati { Id = 13, CalisanId = 3, DayOfWeek = "Pazartesi", StartTime = new TimeSpan(8, 30, 0), EndTime = new TimeSpan(17, 30, 0) },
                new CalismaSaati { Id = 14, CalisanId = 3, DayOfWeek = "Salı", StartTime = new TimeSpan(8, 30, 0), EndTime = new TimeSpan(17, 30, 0) },
                new CalismaSaati { Id = 15, CalisanId = 3, DayOfWeek = "Çarşamba", StartTime = new TimeSpan(8, 30, 0), EndTime = new TimeSpan(17, 30, 0) },
                new CalismaSaati { Id = 16, CalisanId = 3, DayOfWeek = "Perşembe", StartTime = new TimeSpan(8, 30, 0), EndTime = new TimeSpan(17, 30, 0) },
                new CalismaSaati { Id = 17, CalisanId = 3, DayOfWeek = "Cuma", StartTime = new TimeSpan(8, 30, 0), EndTime = new TimeSpan(17, 30, 0) },
                new CalismaSaati { Id = 18, CalisanId = 3, DayOfWeek = "Cumartesi", StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(14, 0, 0) }
            );



        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=BERBERshop;Trusted_Connection=True;");
        }
    }
}
