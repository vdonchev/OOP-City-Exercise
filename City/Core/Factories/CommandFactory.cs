namespace City.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Contracts;
    using Exceptions;

    public static class CommandFactory
    {
        public static ICommand Create(string commandName, ICityBuilder cityBuilder)
        {
            var commandType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(type => type.CustomAttributes.Any(a => a.AttributeType == typeof(CommandAttribute)) &&
                                        type.Name.Equals(commandName));

            if (commandType == null)
            {
                throw new CommandNotImplementedExcepton($"'{commandName}' command is not implemented yet.");
            }

            ICommand command = Activator.CreateInstance(commandType, cityBuilder) as ICommand;

            return command;
        }
    }
}