using System;
using System.Collections.Generic;

namespace Buổi_10_Layout_Fruitables.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public double Price { get; set; }

    public string? ImageUrl { get; set; }

    public int CategoryId { get; set; }

    public int Quantity { get; set; }

    public string ProductName { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;
}
