using EfCoreCodeFirst.Modelos;
using Microsoft.EntityFrameworkCore;

namespace EfCoreCodeFirst;

public class SqlContext : DbContext
{
    public SqlContext(DbContextOptions<SqlContext> options)  : base(options) { }
    
    public DbSet<Imovel> Imoveis { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Proprietario> Proprietarios { get; set; }
    public DbSet<Contato> Contatos { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Endereco>()
            .ToTable("enderecos_sistema")
            .Property(x =>x.Complemento)
            .HasColumnName("complemento")
            .HasMaxLength(20);
        
        modelBuilder.Entity<Endereco>()
            .Property(x =>x.Bairro)
            .HasColumnName("bairro")
            .IsRequired()
            .HasMaxLength(50);
                
        modelBuilder.Entity<Endereco>()
            .Property(x =>x.Cidade)
            .HasColumnName("cidade")
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder.Entity<Endereco>()
            .Property(x =>x.Numero)
            .HasColumnName("numero")
            .IsRequired()
            .HasMaxLength(10);
                        
        modelBuilder.Entity<Endereco>()
            .Property(x =>x.Referencia)
            .HasColumnName("referencia")
            .IsRequired()
            .HasMaxLength(50);
        
        modelBuilder.Entity<Endereco>()
            .Property(x =>x.Rua)
            .HasColumnName("rua")
            .IsRequired()
            .HasMaxLength(200);
                        
        modelBuilder.Entity<Endereco>()
            .Property(x =>x.UF)
            .HasColumnName("uf")
            .IsRequired()
            .HasMaxLength(2);
                        
        modelBuilder.Entity<Endereco>()
            .Property(x =>x.CEP)
            .HasColumnName("cep")
            .IsRequired()
            .HasMaxLength(10);
    }
}