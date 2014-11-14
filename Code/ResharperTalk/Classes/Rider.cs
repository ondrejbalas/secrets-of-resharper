using System.Collections.Generic;
using ResharperTalk.Abstractions;

namespace ResharperTalk.Classes
{
    public class Rider : IRider
    {
        private sealed class NameEqualityComparer : IEqualityComparer<Rider>
        {
            public bool Equals(Rider x, Rider y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return string.Equals(x.Name, y.Name);
            }

            public int GetHashCode(Rider obj)
            {
                return (obj.Name != null ? obj.Name.GetHashCode() : 0);
            }
        }

        private static readonly IEqualityComparer<Rider> NameComparerInstance = new NameEqualityComparer();

        public static IEqualityComparer<Rider> NameComparer
        {
            get { return NameComparerInstance; }
        }

        public Rider()
        {
        }

        protected bool Equals(Rider other)
        {
            return string.Equals(Name, other.Name) && Height == other.Height && Weight == other.Weight;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Rider) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ Height;
                hashCode = (hashCode*397) ^ Weight;
                return hashCode;
            }
        }

        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}