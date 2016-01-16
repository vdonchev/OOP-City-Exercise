namespace City.IO
{
    using System;
    using Contracts;

    public class ConsoleRenderer : IRenderer
    {
        public string Render()
        {
            var line = Console.ReadLine();

            return line;
        }
    }
}