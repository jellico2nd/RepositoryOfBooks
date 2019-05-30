using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models.Interfaces
{
    interface IShop
    {
        string Name { get; set; }
        IGeoLocation Location { get; }
        void Lend(ISellable item);
        ICollection<ISellable> ItemsToSell { get; }
    }
}
