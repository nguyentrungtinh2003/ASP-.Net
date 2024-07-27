using System;
using System.Collections.Generic;

namespace Buổi_12_Lab_07.Models;

public partial class Product
{
    /// <summary>
    /// Mã hàng hóa
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Tên hàng hóa
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Đơn giá
    /// </summary>
    public double UnitPrice { get; set; }

    /// <summary>
    /// Hình ảnh
    /// </summary>
    public string Image { get; set; } = null!;

    /// <summary>
    /// Mô tả hàng hóa
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Mã loại, FK
    /// </summary>
    public int CategoryId { get; set; }

    /// <summary>
    /// Mã nhà cung cấp
    /// </summary>
    public string SupplierId { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
