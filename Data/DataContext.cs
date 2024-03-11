using HW_UsersControls.Classes;
using Microsoft.EntityFrameworkCore;

namespace HW_UsersControls.Data;

public class DataContext : DbContext
{
    public DbSet<Note> Notes { get; set; } = null!;
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

}
