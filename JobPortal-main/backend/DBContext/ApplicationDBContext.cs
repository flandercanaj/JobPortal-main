using backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backend.DBContext;

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        // DbSet for your custom entities
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<JobListing> JobListings { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PremiumPlan> PremiumPlan { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Connections> Connections { get; set; }
        public DbSet<Interview> Interview { get; set; }
        public DbSet<JobApplication> JobApplication { get; set; }
        public DbSet<Resume> Resume { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Experience> Experience { get; set; }
        
        // 
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompanyId); // Primary key configuration

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(20)
                    .IsRequired();

                entity.Property(e => e.Industry)
                    .HasMaxLength(20)
                    .IsRequired();

                entity.Property(e => e.ConctactEmail)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasAnnotation("RegularExpression", @"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .HasAnnotation("RegularExpression", @"^www\.[a-zA-Z0-9\-]+\.[a-zA-Z]{2,}$");
            });

           modelBuilder.Entity<JobListing>()
                .HasOne(j => j.Company)
                .WithMany(c => c.JobListing)
                .HasForeignKey(j => j.CompanyId);

            modelBuilder.Entity<Payment>()
                .HasOne(p => p.User)
                .WithMany(u => u.Payment) 
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<PremiumPlan>()
                .HasOne(pp => pp.Payment)
                .WithOne(pp => pp.PremiumPlan)
                .HasForeignKey<PremiumPlan>(pp => pp.PaymentId);

           
            modelBuilder.Entity<Messages>()
                .HasOne(m => m.User) 
                .WithMany(u => u.Messages) 
                .HasForeignKey(m => m.UserId); 

            modelBuilder.Entity<Resume>()
                .HasOne(r => r.User) 
                .WithMany(u => u.Resume) 
                .HasForeignKey(r => r.UserId); 

            modelBuilder.Entity<Resume>()
                .HasOne(r => r.JobApplication) 
                .WithMany(j => j.Resume) 
                .HasForeignKey(r => r.ApplicationId); 

            modelBuilder.Entity<Connections>()
                .HasOne(c => c.User) 
                .WithMany(u => u.Connections) 
                .HasForeignKey(c => c.UserId); 

            modelBuilder.Entity<Interview>()
                .HasOne(i => i.User) 
                .WithMany(u => u.Interview) 
                .HasForeignKey(i => i.UserId); 

            modelBuilder.Entity<Interview>()
                .HasOne(i => i.JobApplication) 
                .WithMany(j => j.Interview) 
                .HasForeignKey(i => i.ApplicationId); 

            modelBuilder.Entity<JobApplication>()
                .HasOne(ja => ja.User) 
                .WithMany(u => u.JobApplication) 
                .HasForeignKey(ja => ja.UserId); 

            modelBuilder.Entity<JobApplication>()
                .HasOne(ja => ja.JobListing) 
                .WithMany(jl => jl.JobApplication) 
                .HasForeignKey(ja => ja.JobId); 

            modelBuilder.Entity<JobApplication>()
                .HasMany(ja => ja.Interview) 
                .WithOne(i => i.JobApplication) 
                .HasForeignKey(i => i.ApplicationId); 

            modelBuilder.Entity<JobApplication>()
                .HasMany(ja => ja.Resume) 
                .WithOne(r => r.JobApplication) 
                .HasForeignKey(r => r.ApplicationId); 

            modelBuilder.Entity<Permission>()
                .HasOne(r =>  r.User)
                .HasForeignKey( u => u.Role_ID);

            modelBuilder.Entity<Post>()
                .HasOne(u => u.Education)
                .WithMany(e => e.User)
                .HasForeignKey(u =>u.User_ID);

            modelBuilder.Entity<Education>()
                .HasMany( u => u.Post)
                .WithOne(e => e.User)
                .WithMany(s => s.Educations)
                .HasForeignKey(p => p.User_ID);

            modelBuilder.Entity<Experience>()
                .HasMany(c => c.User )
                .WithOne(u => u.Certificate)
                .HasForeignKey( u => u.User_ID);
                
            
      

            //  
           
            modelBuilder.Entity<Calendar>()
                .HasKey(c => c.CalendarId);

            modelBuilder.Entity<Calendar>()
                .HasOne(c => c.User)
                .WithMany(u => u.Calendar)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<Calendar>()
                .HasMany(c => c.Events)
                .WithOne(e => e.Calendar)
                .HasForeignKey(e => e.CalendarId);

            modelBuilder.Entity<Event>()
                .HasKey(e => e.EventId);

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Calendar)
                .WithMany(c => c.Events)
                .HasForeignKey(e => e.CalendarId);

            modelBuilder.Entity<Reminder>()
                .HasKey(r => r.ReminderId);

            modelBuilder.Entity<Reminder>()
                .HasOne(r => r.Event)
                .WithMany(e => e.Reminders)
                .HasForeignKey(r => r.EventId);

            modelBuilder.Entity<Certificate>()
                .HasKey(c => c.CertificateId);

            modelBuilder.Entity<Certificate>()
                .HasOne(c => c.User)
                .WithMany(u => u.Certificate)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<Certificate>()
                .HasOne(c => c.Skill)
                .WithMany(s => s.Certificates)
                .HasForeignKey(c => c.SkillId);

            modelBuilder.Entity<Skill>()
                .HasKey(s => s.SkillId);

            modelBuilder.Entity<Skill>()
                .HasOne(s => s.User)
                .WithMany(u => u.Skill)
                .HasForeignKey(s => s.UserId);

            modelBuilder.Entity<Skill>()
                .HasMany(s => s.Certificates)
                .WithOne(c => c.Skill)
                .HasForeignKey(c => c.SkillId);

            modalBuilder.Entity<Roles>()
                .HasKey(r => r.RolesId);
                        
            modelBuilder. Entity<Roles>()
                .HasOne(u => u.Roles)
                .WithOne(r => r.Premission);

            
            
            
                
            // Foreign key property
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(modelBuilder);
        }
}