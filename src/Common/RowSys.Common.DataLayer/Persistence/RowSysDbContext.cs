using Microsoft.EntityFrameworkCore;
using RowSys.Common.BusinessLayer.Entities;

namespace RowSys.Common.DataLayer.Persistence;

public class RowSysDbContext : DbContext
{
    public DbSet<Competition> Competitions { get; set; }
    public DbSet<Competitor> Competitors { get; set; }
    public DbSet<Discipline> Disciplines { get; set; }
    public DbSet<Result> Results { get; set; }
    public DbSet<Team> Teams { get; set; }
    
    public RowSysDbContext()
    {
    }

    public RowSysDbContext(DbContextOptions options) : base(options)
    {
    }
    
    
}