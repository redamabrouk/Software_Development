using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class SingleGift : GiftBase
{
    public SingleGift(string name, int price)
        :base(name, price)
    {
    }
 
    public override int CalculateTotalPrice()
    {
        Console.WriteLine("{0} with the price {1}", name, price);
 
        return price;
    }
}
}
