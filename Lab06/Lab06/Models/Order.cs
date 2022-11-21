using System.Collections.Generic;

namespace Lab06.Models;
public sealed class Order
{
    public string ClientId { get; set; }
    public List<Product> Products { get; set; }
}
