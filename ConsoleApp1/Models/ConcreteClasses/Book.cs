using ConsoleApp1.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models.ConcreteClasses
{
    public class Book : ILendable
    {
        private string _name;
        private DateTime _leaseStartDate;

        public Book(string Name, int MaxLeaseDuration)
        {
            _name = Name;
            this.MaxLeaseDuration = MaxLeaseDuration;
        }
        public int MaxLeaseDuration { get; }
        public DateTime LeaseStartDate
        {
            get
            {
                return _leaseStartDate;
            }
            set
            {
                _leaseStartDate = value;
                ReturnDate = value.AddDays(MaxLeaseDuration);
            }
        }
        public DateTime ReturnDate { get; set; }

        public override string ToString()
        {
            return String.Format($"{_name} - Can be borrowd for maximum {MaxLeaseDuration} days.");
        }
    }
}
