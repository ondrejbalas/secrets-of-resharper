using ResharperTalk.Abstractions;

namespace ResharperTalk.Classes
{
    class Engine : IEngine
    {
        public int Cylinders { get; set; }
        private string name;

        public decimal LitersRr { get; set; }
        
    }
}