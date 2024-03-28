using Microsoft.EntityFrameworkCore;
using PersonalCollection.Domain.Entities.Attachments;
using PersonalCollection.Domain.Entities.Collections;
using PersonalCollection.Domain.Entities.Comments;
using PersonalCollection.Domain.Entities.Items;
using PersonalCollection.Domain.Entities.Likes;
using PersonalCollection.Domain.Entities.User;
using PersonalCollection.Domain.Entities.Users;

namespace PersonalCollection.Data.DbContexts;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public virtual DbSet<Attachment> Attachments { get; set; }
    public virtual DbSet<Collection> Collections { get; set; }
    public virtual DbSet<Comment> Comments { get; set; }
    public virtual DbSet<Item> Items { get; set; }
    public virtual DbSet<Like> Likes { get; set; }
    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().
            HasIndex(u => u.Email).IsUnique(true);

        modelBuilder.Entity<Collection>().
            HasIndex(u => u.CollectionName).IsUnique(true);
        
        modelBuilder.Entity<Item>().
            HasIndex(u => u.Name).IsUnique(true);

    }
}
