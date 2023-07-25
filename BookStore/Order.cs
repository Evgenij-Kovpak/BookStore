using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore;

public class Order
{
    public int Id { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }
    public Book Book { get; set; }
}
