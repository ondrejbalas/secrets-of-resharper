namespace ResharperTalk.Abstractions
{
    public interface IDriver
    {
        string Name { get; set; }
        int Height { get; set; }
        int Weight { get; set; }
        string FavoriteColor { get; set; }
    }
}