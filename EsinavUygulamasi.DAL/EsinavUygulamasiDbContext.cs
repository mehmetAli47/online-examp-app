using EsinavUygulamasi.DAL.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace EsinavUygulamasi.DAL
{
    public class EsinavUygulamasiDbContext : DbContext
    {
        public EsinavUygulamasiDbContext(DbContextOptions<EsinavUygulamasiDbContext> options) : base(options)
        {

        }
        public EsinavUygulamasiDbContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>()
                .HasOne<Role>(ur => ur.Role)
                .WithMany(r => r.userRoles)
                .HasForeignKey(ur => ur.RoleId);
            modelBuilder.Entity<UserRole>()
                .HasOne<User>(ur => ur.Users)
                .WithMany(u => u.userRoles)
                .HasForeignKey(ur => ur.UserId);
            modelBuilder.Entity<TestQuestion>()
                .HasOne<Test>(tq => tq.Tests)
                .WithMany(t => t.TestQuestions)
                .HasForeignKey(tq => tq.TestId);
            modelBuilder.Entity<TestQuestion>()
                .HasOne<Question>(tq => tq.Questions)
                .WithMany(q => q.TestQuestions)
                .HasForeignKey(tq => tq.QuestionId);
            modelBuilder.Entity<TestQuestion>()
                .HasOne<Question>(tq => tq.Questions)
                .WithMany(q => q.TestQuestions)
                .HasForeignKey(tq => tq.QuestionId);

            modelBuilder.Entity<UserTestInformationView>().ToView("user_jointest_vm");
            modelBuilder.Entity<UserInTheTest>().ToView("user_in_the_test");
            modelBuilder.Entity<UsersTestStatV>().ToView("users_test_stat_v");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<TestQuestion> TestQuestions { get; set; }
        public DbSet<UserTest> UserTests { get; set; }
        public DbSet<UserTestInformationView> userTestInformationViews { get; set; }
        public DbSet<UserInTheTest> userInTheTests { get; set; }
        public DbSet<UsersTestStatV> usersTestStats { get; set; }


    }
}
