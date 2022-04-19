using EfCoreCodeFirst.Modelos;
using Microsoft.EntityFrameworkCore;

namespace EfCoreCodeFirst;

public class SqlContext : DbContext
{
    public SqlContext(DbContextOptions<SqlContext> options)  : base(options) { }
    
    public DbSet<Imovel> Imoveis { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            
    }
}