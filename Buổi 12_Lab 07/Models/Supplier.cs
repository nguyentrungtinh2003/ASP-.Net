using System;
using System.Collections.Generic;

namespace Buổi_12_Lab_07.Models;

public partial class Supplier
{
    /// <summary>
    /// Mã nhà cung cấp
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// Tên công ty
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Logo nhà cung cấp
    /// </summary>
    public string Logo { get; set; } = null!;

    /// <summary>
    /// Email
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// Số điện thoại liên lạc
    /// </summary>
    public string Phone { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
