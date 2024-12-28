using Bshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Bshop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Eğer başka bir yerden konfigürasyon sağlanıyorsa, burayı kaldırabilirsiniz.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=BerberShopDB;Trusted_Connection=True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<Calisan> Calisans { get; set; }
        public DbSet<Hizmet> Hizmets { get; set; }
        public DbSet<CalisanHizmet> CalisanHizmets { get; set; }
        public DbSet<CalismaSaati> CalismaSaatis { get; set; }
        public DbSet<Randevu> Randevular { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // İlişki yapılandırmaları

            // Kullanıcı ve Randevu arasındaki ilişkiyi yapılandırma
            modelBuilder.Entity<Randevu>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Salon ve Calisan arasındaki ilişkiyi yapılandırma
            modelBuilder.Entity<Salon>()
                .HasMany(s => s.Calisans)
                .WithOne(c => c.Salon)
                .HasForeignKey(c => c.SalonId)
                .OnDelete(DeleteBehavior.Cascade);

            // Hizmet ve CalisanHizmet arasındaki ilişkiyi yapılandırma
            modelBuilder.Entity<Hizmet>()
                .HasMany(h => h.CalisanHizmetleri)
                .WithOne(ch => ch.Hizmet)
                .HasForeignKey(ch => ch.HizmetId)
                .OnDelete(DeleteBehavior.Restrict);

            // Calisan ve CalisanHizmet arasındaki ilişkiyi yapılandırma
            modelBuilder.Entity<Calisan>()
                .HasMany(c => c.CalisanHizmetleri)
                .WithOne(ch => ch.Calisan)
                .HasForeignKey(ch => ch.CalisanId)
                .OnDelete(DeleteBehavior.Cascade);

            // CalisanHizmet modeli için benzersiz kısıtlama ekleme
            modelBuilder.Entity<CalisanHizmet>()
                .HasIndex(ch => new { ch.CalisanId, ch.HizmetId })
                .IsUnique();

            // Randevu ve CalisanHizmet arasındaki ilişkiyi yapılandırma
            modelBuilder.Entity<Randevu>()
                .HasOne(r => r.CalisanHizmet)
                .WithMany()
                .HasForeignKey(r => r.CalisanHizmetId)
                .OnDelete(DeleteBehavior.Restrict);

            // Veri Seeding
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // **1. Kullanıcılar (Users)**
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FullName = "John Doe", Phone = "0500 000 0000", Email = "john@example.com", Password = "password123", Role = UserRole.User },
                new User { Id = 2, FullName = "Jane Smith", Phone = "0500 000 0001", Email = "jane@example.com", Password = "password123", Role = UserRole.User },
                new User { Id = 3, FullName = "Alice Johnson", Phone = "0500 000 0002", Email = "alice@example.com", Password = "password123", Role = UserRole.User },
                new User { Id = 4, FullName = "Michael Brown", Phone = "0500 000 0003", Email = "michael@example.com", Password = "password123", Role = UserRole.User },
                new User { Id = 5, FullName = "Emily Davis", Phone = "0500 000 0004", Email = "emily@example.com", Password = "password123", Role = UserRole.User },
                new User { Id = 6, FullName = "David Wilson", Phone = "0500 000 0005", Email = "david@example.com", Password = "password123", Role = UserRole.User },
                new User { Id = 7, FullName = "Sarah Miller", Phone = "0500 000 0006", Email = "sarah@example.com", Password = "password123", Role = UserRole.User },
                new User { Id = 8, FullName = "Chris Martin", Phone = "0500 000 0007", Email = "chris@example.com", Password = "password123", Role = UserRole.User },
                new User { Id = 9, FullName = "Lisa Taylor", Phone = "0500 000 0008", Email = "lisa@example.com", Password = "password123", Role = UserRole.User },
                new User { Id = 10, FullName = "Tom Clark", Phone = "0500 000 0009", Email = "tom@example.com", Password = "password123", Role = UserRole.User }
            );

            // **2. Salonlar (Salons)**
            modelBuilder.Entity<Salon>().HasData(
                new Salon { Id = 1, Name = "Güzellik Merkezi A", Location = "İstanbul", ContactNumber = "0212 555 1234" },
                new Salon { Id = 2, Name = "Saç ve Cilt Studio", Location = "Ankara", ContactNumber = "0312 555 5678" },
                new Salon { Id = 3, Name = "Elegance Salonu", Location = "İzmir", ContactNumber = "0232 555 9012" },
                new Salon { Id = 4, Name = "Premium Güzellik", Location = "Bursa", ContactNumber = "0228 555 3456" },
                new Salon { Id = 5, Name = "Moda Saç Salonu", Location = "Antalya", ContactNumber = "0242 555 7890" },
                new Salon { Id = 6, Name = "Sihirli Eller", Location = "Adana", ContactNumber = "0322 555 2345" },
                new Salon { Id = 7, Name = "Şıklık Noktası", Location = "Trabzon", ContactNumber = "0462 555 6789" },
                new Salon { Id = 8, Name = "Lüks Güzellik", Location = "Gaziantep", ContactNumber = "0342 555 0123" },
                new Salon { Id = 9, Name = "Parlak Saç", Location = "Kayseri", ContactNumber = "0352 555 4567" },
                new Salon { Id = 10, Name = "Zarif Cilt Bakımı", Location = "Konya", ContactNumber = "0332 555 8901" }
            );

           // Çalışan verilerini bir listeye eklemek için
            var calisanlar = new List<Calisan>();

            // Çalışanları her salon için oluşturuyoruz
            for (int salonId = 1; salonId <= 10; salonId++)
            {
                calisanlar.Add(new Calisan { Id = (salonId - 1) * 10 + 1, FullName = "Mehmet Yılmaz", SalonId = salonId, ExperienceYears = 5 });
                calisanlar.Add(new Calisan { Id = (salonId - 1) * 10 + 2, FullName = "Ayşe Demir", SalonId = salonId, ExperienceYears = 3 });
                calisanlar.Add(new Calisan { Id = (salonId - 1) * 10 + 3, FullName = "Fatma Kaya", SalonId = salonId, ExperienceYears = 4 });
                calisanlar.Add(new Calisan { Id = (salonId - 1) * 10 + 4, FullName = "Ali Can", SalonId = salonId, ExperienceYears = 6 });
                calisanlar.Add(new Calisan { Id = (salonId - 1) * 10 + 5, FullName = "Elif Öz", SalonId = salonId, ExperienceYears = 2 });
                calisanlar.Add(new Calisan { Id = (salonId - 1) * 10 + 6, FullName = "Burak Şahin", SalonId = salonId, ExperienceYears = 7 });
                calisanlar.Add(new Calisan { Id = (salonId - 1) * 10 + 7, FullName = "Deniz Arslan", SalonId = salonId, ExperienceYears = 4 });
                calisanlar.Add(new Calisan { Id = (salonId - 1) * 10 + 8, FullName = "Zeynep Aydın", SalonId = salonId, ExperienceYears = 5 });
                calisanlar.Add(new Calisan { Id = (salonId - 1) * 10 + 9, FullName = "Okan Güneş", SalonId = salonId, ExperienceYears = 3 });
                calisanlar.Add(new Calisan { Id = (salonId - 1) * 10 + 10, FullName = "Selin Toprak", SalonId = salonId, ExperienceYears = 4 });
            }

            // Hizmets verilerini erkek berber hizmetlerine göre güncelleyin ve PhotoUrl'leri aynı yapın
            modelBuilder.Entity<Hizmet>().HasData(
                new Hizmet
                {
                    Id = 1,
                    Name = "Saç Kesimi",
                    Description = "Profesyonel saç kesimi hizmeti.",
                    DurationMinutes = 30,
                    Price = 100,
                    PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg"
                },
                new Hizmet
                {
                    Id = 2,
                    Name = "Cilt Bakımı",
                    Description = "Derinlemesine cilt bakımı.",
                    DurationMinutes = 60,
                    Price = 200,
                    PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg"
                },
                new Hizmet
                {
                    Id = 3,
                    Name = "Manikür",
                    Description = "Bakımlı tırnaklar için manikür.",
                    DurationMinutes = 45,
                    Price = 150,
                    PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg"
                },
                new Hizmet
                {
                    Id = 4,
                    Name = "Saç Boyama",
                    Description = "Profesyonel saç boyama hizmeti.",
                    DurationMinutes = 90,
                    Price = 250,
                    PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg"
                },
                new Hizmet
                {
                    Id = 5,
                    Name = "Epilasyon",
                    Description = "Pürüzsüz cilt için epilasyon hizmeti.",
                    DurationMinutes = 75,
                    Price = 180,
                    PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg"
                },
                new Hizmet
                {
                    Id = 6,
                    Name = "Masaj",
                    Description = "Rahatlatıcı masaj hizmeti.",
                    DurationMinutes = 60,
                    Price = 220,
                    PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg"
                },
                new Hizmet
                {
                    Id = 7,
                    Name = "Tırnak Tasarımı",
                    Description = "Özel tırnak tasarımları.",
                    DurationMinutes = 50,
                    Price = 170,
                    PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg"
                },
                new Hizmet
                {
                    Id = 8,
                    Name = "Profesyonel Makyaj",
                    Description = "Özel günler için profesyonel makyaj.",
                    DurationMinutes = 120,
                    Price = 300,
                    PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg"
                },
                new Hizmet
                {
                    Id = 9,
                    Name = "Kaş ve Kirpik Uzatma",
                    Description = "Doğal ve uzun kaş ve kirpikler.",
                    DurationMinutes = 40,
                    Price = 130,
                    PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg"
                },
                new Hizmet
                {
                    Id = 10,
                    Name = "Vücut Bakımı",
                    Description = "Cilt yenileyici vücut bakımı hizmeti.",
                    DurationMinutes = 80,
                    Price = 210,
                    PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg"
                }
            );

            // **5. Çalışan-Hizmet İlişkileri (CalisanHizmets)**
            modelBuilder.Entity<CalisanHizmet>().HasData(
                new CalisanHizmet { Id = 1, CalisanId = 1, HizmetId = 1 },
                new CalisanHizmet { Id = 2, CalisanId = 1, HizmetId = 2 },
                new CalisanHizmet { Id = 3, CalisanId = 2, HizmetId = 2 },
                new CalisanHizmet { Id = 4, CalisanId = 2, HizmetId = 3 },
                new CalisanHizmet { Id = 5, CalisanId = 3, HizmetId = 1 },
                new CalisanHizmet { Id = 6, CalisanId = 3, HizmetId = 3 },
                new CalisanHizmet { Id = 7, CalisanId = 4, HizmetId = 4 },
                new CalisanHizmet { Id = 8, CalisanId = 5, HizmetId = 7 },
                new CalisanHizmet { Id = 9, CalisanId = 6, HizmetId = 5 },
                new CalisanHizmet { Id = 10, CalisanId = 7, HizmetId = 6 },
                new CalisanHizmet { Id = 11, CalisanId = 8, HizmetId = 2 },
                new CalisanHizmet { Id = 12, CalisanId = 9, HizmetId = 4 },
                new CalisanHizmet { Id = 13, CalisanId = 10, HizmetId = 8 }
            );

            // **6. Çalışma Saatleri (CalismaSaatis)**
            modelBuilder.Entity<CalismaSaati>().HasData(
                // Çalışan 1 - Mehmet Yılmaz
                new CalismaSaati { Id = 1, CalisanId = 1, Gun = DayOfWeek.Monday, BaslangicSaati = new TimeSpan(09, 0, 0), BitisSaati = new TimeSpan(17, 0, 0) },
                new CalismaSaati { Id = 2, CalisanId = 1, Gun = DayOfWeek.Tuesday, BaslangicSaati = new TimeSpan(09, 0, 0), BitisSaati = new TimeSpan(17, 0, 0) },
                new CalismaSaati { Id = 3, CalisanId = 1, Gun = DayOfWeek.Wednesday, BaslangicSaati = new TimeSpan(09, 0, 0), BitisSaati = new TimeSpan(17, 0, 0) },
                new CalismaSaati { Id = 4, CalisanId = 1, Gun = DayOfWeek.Thursday, BaslangicSaati = new TimeSpan(09, 0, 0), BitisSaati = new TimeSpan(17, 0, 0) },

                // Çalışan 2 - Ayşe Demir
                new CalismaSaati { Id = 5, CalisanId = 2, Gun = DayOfWeek.Monday, BaslangicSaati = new TimeSpan(10, 0, 0), BitisSaati = new TimeSpan(18, 0, 0) },
                new CalismaSaati { Id = 6, CalisanId = 2, Gun = DayOfWeek.Wednesday, BaslangicSaati = new TimeSpan(10, 0, 0), BitisSaati = new TimeSpan(18, 0, 0) },
                new CalismaSaati { Id = 7, CalisanId = 2, Gun = DayOfWeek.Friday, BaslangicSaati = new TimeSpan(10, 0, 0), BitisSaati = new TimeSpan(18, 0, 0) },

                // Çalışan 3 - Fatma Kaya
                new CalismaSaati { Id = 8, CalisanId = 3, Gun = DayOfWeek.Tuesday, BaslangicSaati = new TimeSpan(08, 30, 0), BitisSaati = new TimeSpan(16, 30, 0) },
                new CalismaSaati { Id = 9, CalisanId = 3, Gun = DayOfWeek.Thursday, BaslangicSaati = new TimeSpan(08, 30, 0), BitisSaati = new TimeSpan(16, 30, 0) },
                new CalismaSaati { Id = 10, CalisanId = 3, Gun = DayOfWeek.Saturday, BaslangicSaati = new TimeSpan(08, 30, 0), BitisSaati = new TimeSpan(16, 30, 0) },

                // Çalışan 4 - Ali Can
                new CalismaSaati { Id = 11, CalisanId = 4, Gun = DayOfWeek.Monday, BaslangicSaati = new TimeSpan(09, 0, 0), BitisSaati = new TimeSpan(17, 0, 0) },
                new CalismaSaati { Id = 12, CalisanId = 4, Gun = DayOfWeek.Wednesday, BaslangicSaati = new TimeSpan(09, 0, 0), BitisSaati = new TimeSpan(17, 0, 0) },
                new CalismaSaati { Id = 13, CalisanId = 4, Gun = DayOfWeek.Friday, BaslangicSaati = new TimeSpan(09, 0, 0), BitisSaati = new TimeSpan(17, 0, 0) },

                // Çalışan 5 - Elif Öz
                new CalismaSaati { Id = 14, CalisanId = 5, Gun = DayOfWeek.Tuesday, BaslangicSaati = new TimeSpan(10, 0, 0), BitisSaati = new TimeSpan(18, 0, 0) },
                new CalismaSaati { Id = 15, CalisanId = 5, Gun = DayOfWeek.Thursday, BaslangicSaati = new TimeSpan(10, 0, 0), BitisSaati = new TimeSpan(18, 0, 0) },

                // Çalışan 6 - Burak Şahin
                new CalismaSaati { Id = 16, CalisanId = 6, Gun = DayOfWeek.Monday, BaslangicSaati = new TimeSpan(08, 0, 0), BitisSaati = new TimeSpan(16, 0, 0) },
                new CalismaSaati { Id = 17, CalisanId = 6, Gun = DayOfWeek.Wednesday, BaslangicSaati = new TimeSpan(08, 0, 0), BitisSaati = new TimeSpan(16, 0, 0) },
                new CalismaSaati { Id = 18, CalisanId = 6, Gun = DayOfWeek.Friday, BaslangicSaati = new TimeSpan(08, 0, 0), BitisSaati = new TimeSpan(16, 0, 0) },

                // Çalışan 7 - Deniz Arslan
                new CalismaSaati { Id = 19, CalisanId = 7, Gun = DayOfWeek.Tuesday, BaslangicSaati = new TimeSpan(09, 30, 0), BitisSaati = new TimeSpan(17, 30, 0) },
                new CalismaSaati { Id = 20, CalisanId = 7, Gun = DayOfWeek.Thursday, BaslangicSaati = new TimeSpan(09, 30, 0), BitisSaati = new TimeSpan(17, 30, 0) },
                new CalismaSaati { Id = 21, CalisanId = 7, Gun = DayOfWeek.Saturday, BaslangicSaati = new TimeSpan(09, 30, 0), BitisSaati = new TimeSpan(17, 30, 0) },

                // Çalışan 8 - Zeynep Aydın
                new CalismaSaati { Id = 22, CalisanId = 8, Gun = DayOfWeek.Monday, BaslangicSaati = new TimeSpan(10, 0, 0), BitisSaati = new TimeSpan(18, 0, 0) },
                new CalismaSaati { Id = 23, CalisanId = 8, Gun = DayOfWeek.Wednesday, BaslangicSaati = new TimeSpan(10, 0, 0), BitisSaati = new TimeSpan(18, 0, 0) },
                new CalismaSaati { Id = 24, CalisanId = 8, Gun = DayOfWeek.Friday, BaslangicSaati = new TimeSpan(10, 0, 0), BitisSaati = new TimeSpan(18, 0, 0) },

                // Çalışan 9 - Okan Güneş
                new CalismaSaati { Id = 25, CalisanId = 9, Gun = DayOfWeek.Tuesday, BaslangicSaati = new TimeSpan(09, 0, 0), BitisSaati = new TimeSpan(17, 0, 0) },
                new CalismaSaati { Id = 26, CalisanId = 9, Gun = DayOfWeek.Thursday, BaslangicSaati = new TimeSpan(09, 0, 0), BitisSaati = new TimeSpan(17, 0, 0) },
                new CalismaSaati { Id = 27, CalisanId = 9, Gun = DayOfWeek.Saturday, BaslangicSaati = new TimeSpan(09, 0, 0), BitisSaati = new TimeSpan(17, 0, 0) },

                // Çalışan 10 - Selin Toprak
                new CalismaSaati { Id = 28, CalisanId = 10, Gun = DayOfWeek.Tuesday, BaslangicSaati = new TimeSpan(08, 0, 0), BitisSaati = new TimeSpan(16, 0, 0) },
                new CalismaSaati { Id = 29, CalisanId = 10, Gun = DayOfWeek.Thursday, BaslangicSaati = new TimeSpan(08, 0, 0), BitisSaati = new TimeSpan(16, 0, 0) },
                new CalismaSaati { Id = 30, CalisanId = 10, Gun = DayOfWeek.Saturday, BaslangicSaati = new TimeSpan(08, 0, 0), BitisSaati = new TimeSpan(16, 0, 0) }
            );

            // **7. Randevular (Randevular)**
            modelBuilder.Entity<Randevu>().HasData(
                new Randevu { Id = 1, UserId = 1, SalonId = 1, CalisanHizmetId = 1, RandevuSaati = new DateTime(2024, 1, 10, 10, 0, 0) },
                new Randevu { Id = 2, UserId = 2, SalonId = 2, CalisanHizmetId = 3, RandevuSaati = new DateTime(2024, 1, 11, 11, 30, 0) },
                new Randevu { Id = 3, UserId = 3, SalonId = 3, CalisanHizmetId = 5, RandevuSaati = new DateTime(2024, 1, 12, 09, 0, 0) },
                new Randevu { Id = 4, UserId = 4, SalonId = 4, CalisanHizmetId = 7, RandevuSaati = new DateTime(2024, 1, 13, 14, 0, 0) },
                new Randevu { Id = 5, UserId = 5, SalonId = 5, CalisanHizmetId = 9, RandevuSaati = new DateTime(2024, 1, 14, 15, 30, 0) },
                new Randevu { Id = 6, UserId = 6, SalonId = 6, CalisanHizmetId = 10, RandevuSaati = new DateTime(2024, 1, 15, 13, 0, 0) },
                new Randevu { Id = 7, UserId = 7, SalonId = 7, CalisanHizmetId = 6, RandevuSaati = new DateTime(2024, 1, 16, 10, 30, 0) },
                new Randevu { Id = 8, UserId = 8, SalonId = 8, CalisanHizmetId = 2, RandevuSaati = new DateTime(2024, 1, 17, 12, 0, 0) },
                new Randevu { Id = 9, UserId = 9, SalonId = 9, CalisanHizmetId = 4, RandevuSaati = new DateTime(2024, 1, 18, 09, 30, 0) },
                new Randevu { Id = 10, UserId = 10, SalonId = 10, CalisanHizmetId = 8, RandevuSaati = new DateTime(2024, 1, 19, 16, 0, 0) }
            );
        }
    }
}
