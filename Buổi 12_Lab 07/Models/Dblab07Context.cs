using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Buổi_12_Lab_07.Models;

public partial class Dblab07Context : DbContext
{
    public Dblab07Context()
    {
    }

    public Dblab07Context(DbContextOptions<Dblab07Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-RAAS25V;Database=DBLab07;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Id).HasComment("Mã loại");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.NameVn)
                .HasMaxLength(50)
                .HasComment("Tên chủng loại")
                .HasColumnName("NameVN");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Id).HasComment("Mã hàng hóa");
            entity.Property(e => e.CategoryId).HasComment("Mã loại, FK");
            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .HasComment("Mô tả hàng hóa");
            entity.Property(e => e.Image)
                .HasMaxLength(50)
                .HasDefaultValue("Product.gif")
                .HasComment("Hình ảnh");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasComment("Tên hàng hóa");
            entity.Property(e => e.SupplierId)
                .HasMaxLength(50)
                .HasDefaultValue("NK")
                .HasComment("Mã nhà cung cấp");
            entity.Property(e => e.UnitPrice).HasComment("Đơn giá");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_HangHoa_Loai1");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_Products_Suppliers");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasComment("Mã nhà cung cấp");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasComment("Email");
            entity.Property(e => e.Logo)
                .HasMaxLength(50)
                .HasDefaultValue("Logo.gif")
                .HasComment("Logo nhà cung cấp");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Tên công ty");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasComment("Số điện thoại liên lạc");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
