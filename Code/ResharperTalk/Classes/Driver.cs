using System;
using System.Collections.Generic;
using ResharperTalk.Abstractions;

namespace ResharperTalk.Classes
{
    public class Driver : IDriver
    {
        private sealed class NameDobEqualityComparer : IEqualityComparer<Driver>
        {
            public bool Equals(Driver x, Driver y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return string.Equals(x.Name, y.Name) && x.DOB.Equals(y.DOB);
            }

            public int GetHashCode(Driver obj)
            {
                unchecked
                {
                    return ((obj.Name != null ? obj.Name.GetHashCode() : 0) * 397) ^ obj.DOB.GetHashCode();
                }
            }
        }

        public static IEqualityComparer<Driver> NameDobComparer { get; } = new NameDobEqualityComparer();

        public Driver()
        {
        }

        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public DateTime DOB { get; set; }
    }
}