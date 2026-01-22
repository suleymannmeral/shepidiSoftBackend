using Microsoft.EntityFrameworkCore;
using ShepidiSoft.Domain.Entities;
using ShepidiSoft.Domain.Entities.Organizations;
using System.Reflection;

namespace ShepidiSoft.Persistence.Context;

public sealed class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());



        base.OnModelCreating(modelBuilder);


    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<Activity> Activities { get; set; }
    public DbSet<Assignment> Assigments { get; set; }
    public DbSet<AssignmentSubmission> AssigmentSubmissions { get; set; }
    public DbSet<ContactMessage> ContactMessages { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Document> Documents { get; set; }
    public DbSet<DocumentTopic> DocumentTopics { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Offering> Offerings { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectImage> ProjectImages { get; set; }
    public DbSet<Organization> Organizations { get; set; }
    public DbSet<Organization> OrganizationMembers { get; set; }
    public DbSet<OrganizationPosition> OrganizationPositions { get; set; }

}
