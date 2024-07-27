using System;
using System.Collections.Generic;

namespace Buổi_10_Layout_Fruitables.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? ImageUrl { get; set; }

    public string? Description { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
