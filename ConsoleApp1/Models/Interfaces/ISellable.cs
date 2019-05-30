using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models.Interfaces
{
    public interface ISellable
    {
        decimal Price { get; }
        DateTime SellDate { get; }
    }
}
