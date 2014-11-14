namespace ResharperTalk
{
    public class Person
    {
        public string Address { get; set; } 
        public string Address2 { get; set; }
        private string something;

        public Person(string something, string address, string address2)
        {
            this.something = something;
            Address = address;
            Address2 = address2;
        }
    }
}