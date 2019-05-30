using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models.Interfaces
{
    public interface ILendable
    {
        int MaxLeaseDuration { get; }
        DateTime LeaseStartDate { get; }
    }
}
