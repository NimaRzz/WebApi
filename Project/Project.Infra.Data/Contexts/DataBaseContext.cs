using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities.Citizens;
using Project.Domain.Entities.Offices;
using Project.Domain.Entities.Plans;
using Project.Domain.Entities.Province;
using ProvinceNames = Project.Application.Common.Provinces.Province;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Project.Domain.Entities.Appointments;

namespace Project.Infra.Data.Contexts
{
    public class DataBaseContext : IdentityDbContext<User, Role, string>
    {
        #region ctor

        public DataBaseContext(DbContextOptions options) : base(options)
        {

        }

        #endregion

        #region Properties

        public DbSet<Office> Offices { get; set; }

        public DbSet<OfficePlan> OfficePlans { get; set; }

        public DbSet<Citizen> Citizens { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Plan> Plans { get; set; }

        public DbSet<Province> Provinces { get; set; }

        public DbSet<WorkCalendar> WorkCalendars { get; set; }

        #endregion

        #region Methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //FluentApi
            ConfigureFluentApi(modelBuilder);

            //SeedData 
            SeedData(modelBuilder);

            //--برایه عدم نمایش اطلاعات حذف شده
            ApplyQueryFilter(modelBuilder);

        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            #region Entries
            var entries = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified || e.State == EntityState.Deleted || e.State == EntityState.Added);

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Modified)
                {
                    if (entry.GetType().GetProperty("UpdateTime") == null || entry.GetType().GetProperty("UpdateTime") != null)
                    {
                    entry.Property("UpdateTime").CurrentValue = DateTime.Now;
                    }
                }

                if (entry.State == EntityState.Deleted)
                {
                    if(entry.GetType().GetProperty("IsRmoved") == null && entry.GetType().GetProperty("RemoveTime") == null)
                    {
                    entry.Property("IsRemoved").CurrentValue = true;
                    entry.Property("RemoveTime").CurrentValue = DateTime.Now;
                    entry.State = EntityState.Modified;
                    }

                }

                if (entry.State == EntityState.Added)
                {
                    if (entry.GetType().GetProperty("InsertTime") == null)
                    {
                       entry.Property("InsertTime").CurrentValue = DateTime.Now;
                    }

                    if (entry.Entity is OfficePlan officePlan)
                    {
                        if (officePlan.Id == 0)
                        {
                            officePlan.Id = GenerateNewId();
                        }
                    }
                }
            }
            #endregion

            // فراخوانی SaveChangesAsync اصلی
            return await base.SaveChangesAsync(cancellationToken);
        }

        private int GenerateNewId()
        {

            var maxId = this.OfficePlans.Max(op => (int?)op.Id) ?? 0;
            return maxId + 1;

        }
        private void ConfigureFluentApi(ModelBuilder modelBuilder)
        {

            //برایه پیکربندی ارتباط ها

            modelBuilder.Entity<OfficePlan>()
                .HasOne(op => op.Office)
                .WithMany(o => o.OfficePlans)
                .HasForeignKey(op => op.OfficeId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<OfficePlan>()
                .HasOne(op => op.Plan)
                .WithMany(p => p.OfficePlans)
                .HasForeignKey(op => op.PlanId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Office>()
                .HasMany(o => o.WorkCalendars)
                .WithOne(wc => wc.Office)
                .HasForeignKey(wc => wc.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Citizen)
                .WithMany(u => u.Appointments)
                .HasForeignKey(a => a.CitizenId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Plan)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.PlanId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Office>()
                .HasOne(o => o.Province)
                .WithMany(p => p.Offices)
                .HasForeignKey(o => o.ProvinceId)
                .OnDelete(DeleteBehavior.Cascade);


            //برای تنظیم ایدی به صورت دستی
            modelBuilder.Entity<Office>()
                .Property(c => c.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<Plan>()
                .Property(c => c.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<OfficePlan>(entity =>
            {
                entity.Property(o => o.Id)
                 .ValueGeneratedNever();
            });


        }

        private void ApplyQueryFilter(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Citizen>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Office>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<OfficePlan>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Plan>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Appointment>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Province>().HasQueryFilter(p => !p.IsRemoved);

        }

        private void SeedData(ModelBuilder modelBuilder)
        {

            //Provinces
            modelBuilder.Entity<Province>().HasData(new Province { Id = 1, Name = nameof(ProvinceNames.AzarbaijanSharghi), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 2, Name = nameof(ProvinceNames.AzarbaijanGharbi), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 3, Name = nameof(ProvinceNames.Ardabil), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 4, Name = nameof(ProvinceNames.Isfahan), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 5, Name = nameof(ProvinceNames.Alborz), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 6, Name = nameof(ProvinceNames.Ilam), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 7, Name = nameof(ProvinceNames.Bushehr), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 8, Name = nameof(ProvinceNames.Tehran), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 9, Name = nameof(ProvinceNames.ChaharmahaloBakhtiari), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 10, Name = nameof(ProvinceNames.KhorasanJonubi), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 11, Name = nameof(ProvinceNames.KhorasanRazavi), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 12, Name = nameof(ProvinceNames.KhorasanShomali), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 13, Name = nameof(ProvinceNames.Khuzestan), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 14, Name = nameof(ProvinceNames.Zanjan), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 15, Name = nameof(ProvinceNames.Semnan), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 16, Name = nameof(ProvinceNames.SistanoBaluchestan), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 17, Name = nameof(ProvinceNames.Fars), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 18, Name = nameof(ProvinceNames.Qazvin), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 19, Name = nameof(ProvinceNames.Qom), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 20, Name = nameof(ProvinceNames.Kurdistan), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 21, Name = nameof(ProvinceNames.Kerman), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 22, Name = nameof(ProvinceNames.Kermanshah), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 23, Name = nameof(ProvinceNames.KohgiluyehoBoyerahmad), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 24, Name = nameof(ProvinceNames.Golestan), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 25, Name = nameof(ProvinceNames.Gilan), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 26, Name = nameof(ProvinceNames.Lorestan), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 27, Name = nameof(ProvinceNames.Mazandaran), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 28, Name = nameof(ProvinceNames.Markazi), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 29, Name = nameof(ProvinceNames.Hormozgan), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 30, Name = nameof(ProvinceNames.Hamadan), InsertTime = DateTime.Now });
            modelBuilder.Entity<Province>().HasData(new Province { Id = 31, Name = nameof(ProvinceNames.Yazd), InsertTime = DateTime.Now });
        }

        #endregion
    }
}
