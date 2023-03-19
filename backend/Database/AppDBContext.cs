namespace Database;

using Microsoft.EntityFrameworkCore;
using Models;
using Npgsql;

public class AppDbContext : DbContext
{
    // Static constructor which will be run ONCE
    static AppDbContext()
    {

        // Use the legacy timestamp behaviour - check Npgsql for more details
        // Recommendation from Postgres: Don't use time zone in database
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        NpgsqlConnection.GlobalTypeMapper.MapEnum<User.UserRole>();
    }
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Genre> Genres { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    private readonly IConfiguration _config;

    public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration config) : base(options) => _config = config;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connString = _config.GetConnectionString("DefaultConnection");
        optionsBuilder
            .UseNpgsql(connString)
            .AddInterceptors(new AppDbContextSaveChangesInterceptor())
            .UseSnakeCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresEnum<User.UserRole>();
        modelBuilder.Entity<User>(entity => 
        {
            entity.Property(e => e.Role).HasColumnType("role");
            entity.HasIndex(e => e.Email).IsUnique();
        });
        modelBuilder.Entity<BookOrder>(entity =>
        {
            entity.HasOne(e => e.Book)
            .WithMany()
            .HasForeignKey(entity => entity.BookId)
            .OnDelete(DeleteBehavior.Cascade);
            entity
            .HasOne(e => e.Order)
            .WithMany()
            .HasForeignKey(entity => entity.OrderId)
            .OnDelete(DeleteBehavior.Cascade);
        });
    }


}