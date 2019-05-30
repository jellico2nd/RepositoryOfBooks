using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models.Interfaces
{
    public interface ILibrary
    {
        string Name { get; set; }
        IGeoLocation Location { get; }
        void Lend(ILendable item);
        ICollection<ILendable> BooksToLend { get; }
    }
}
