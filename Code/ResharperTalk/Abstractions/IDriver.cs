using System;

namespace ResharperTalk.Abstractions
{
    public interface IDriver
    {
        string Name { get; set; }
        int Height { get; set; }
        int Weight { get; set; }
        DateTime DOB { get; set; }
    }
}