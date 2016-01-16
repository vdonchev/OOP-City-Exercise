namespace City.Core
{
    using System;
    using Contracts;
    using Exceptions;
    using Factories;

    public class CityBuilder : ICityBuilder
    {
        public CityBuilder(ICity city, IRenderer renderer, IWriter writer)
        {
            this.City = city;
            this.Renderer = renderer;
            this.Writer = writer;
            this.IsRunning = false;
        }

        public ICity City { get; private set; }

        public IRenderer Renderer { get; private set; }

        public IWriter Writer { get; private set; }

        public bool IsRunning { get; set; }

        public void Run()
        {
            this.IsRunning = true;

            while (this.IsRunning)
            {
                var commandArgs = this.Renderer.Render().Split();

                try
                {
                    var command = CommandFactory.Create(commandArgs[0], this);
                    command.Execute(commandArgs);
                }
                catch (CommandNotImplementedExcepton ex)
                {
                    this.Writer.Print(ex.Message);
                }
            }
        }

        public void Stop()
        {
            this.IsRunning = false;
        }
    }
}