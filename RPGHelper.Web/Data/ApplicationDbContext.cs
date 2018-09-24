using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RPGHelper.Models.Entities;
using RPGHelper.Models.Tables;
using RPGHelper.Models.Tables.Encounter;
using RPGHelper.Models.Users;
using RPGHelper.Models.Users;

namespace RPGHelper.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public DbContextOptions<ApplicationDbContext> Options { get; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EncounterTable>(b =>
            {
                b.ToTable("EncounterTable");
//                b.HasMany(x => x.CreatureReferences)
//                    .WithOne(x => x.Creature)
//                    .HasForeignKey(x => x.CreatureId)
//                    .OnDelete(DeleteBehavior.Cascade);
//
//                b.HasMany(x => x.CreatureTags)
//                    .WithOne(x => x.Creature)
//                    .HasForeignKey(x => x.CreatureId)
//                    .OnDelete(DeleteBehavior.Cascade);
//                b.HasOne(x => x.Media);
            });

            modelBuilder.Entity<Event>().ToTable("Encounter")
                .HasKey(t => new { t.Id });

            modelBuilder.Entity<User>(b =>
            {
                b.ToTable("User");
            });

            modelBuilder.Entity<Role>(b =>
            {
                b.ToTable("Role");
            });

            modelBuilder.Entity<UserRole>(b =>
            {
                b.ToTable("UserRole");
                b.HasOne("RPGHelper.Models.Users.Role")
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("RPGHelper.Models.Users.User")
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<UserClaim>(b =>
            {
                b.ToTable("UserClaim");
                b.HasOne("ReefTankCore.Models.Users.User")
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<RoleClaim>(b =>
            {
                b.ToTable("RoleClaim");
                b.HasOne("ReefTankCore.Models.Users.Role")
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<UserLogin>(b =>
            {
                b.ToTable("UserLogin");
                b.HasOne("ReefTankCore.Models.Users.User")
                    .WithMany()
                    .HasForeignKey("UserId");
            });

            modelBuilder.Entity<UserToken>(b =>
            {
                b.ToTable("UserToken");
                b.HasOne("ReefTankCore.Models.Users.User")
                    .WithMany()
                    .HasForeignKey("UserId");
            });
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<BaseTable> Tables { get; set; }
    }
}
