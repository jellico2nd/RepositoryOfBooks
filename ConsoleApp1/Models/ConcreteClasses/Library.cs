using ConsoleApp1.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models.ConcreteClasses
{
    public class Library : ILibrary
    {
        private string _name;
        private List<ILendable> _books = new List<ILendable>();

        public Library(string Name)
        {
            _name = Name;
        }

        public string Name { get => _name; set => _name = value; }

        public IGeoLocation Location => throw new NotImplementedException();

        public ICollection<ILendable> BooksToLend => _books;

        public void Lend(ILendable item)
        {
            var list = _books.FindAll(x => x == item);
            list.ForEach(x  => ((Book)x).LeaseStartDate = DateTime.UtcNow);
        }

        public void Add(ILendable lendable)
        {
            _books.Add(lendable);
        }
    }
}
