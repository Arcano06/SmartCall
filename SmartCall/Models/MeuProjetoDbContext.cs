using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SmartCall.Models;

public partial class MeuProjetoDbContext : DbContext
{
    public MeuProjetoDbContext()
    {
    }

    public MeuProjetoDbContext(DbContextOptions<MeuProjetoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chamado> Chamados { get; set; }

    public virtual DbSet<ChamadoMessage> ChamadoMessages { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-C4D4SQ2;Initial Catalog=MeuProjetoDb;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChamadoMessage>(entity =>
        {
            entity.HasIndex(e => e.ChamadoId, "IX_ChamadoMessages_ChamadoId");

            entity.HasOne(d => d.Chamado).WithMany(p => p.ChamadoMessages).HasForeignKey(d => d.ChamadoId);
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.Property(e => e.Preco).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
