using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Zodiac
    {
        public string FirstName;
        public string LastName;
        public string ZodiacName;
        public DateTime DateOfBirth;

        public Zodiac(string FirstName, string LastName, string ZodiacName, DateTime DateOfBirth)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ZodiacName = ZodiacName;
            this.DateOfBirth = DateOfBirth;
        }
    }
}
