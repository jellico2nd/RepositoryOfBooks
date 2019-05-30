using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models.Interfaces
{
    public interface IGeoLocation
    {
        decimal Latitude { get; set; }
        decimal Longitude { get; set; }
    }
}
