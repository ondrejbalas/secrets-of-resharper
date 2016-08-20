using ResharperTalk.Abstractions;

namespace ResharperTalk.Classes
{
    public class Driver : IDriver
    {
        public Driver()
        {
        }

        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public string FavoriteColor { get; set; }
    }
}