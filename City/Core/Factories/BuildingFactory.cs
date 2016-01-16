namespace City.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Contracts;
    using Exceptions;

    public static class BuildingFactory
    {
        public static IBuilding Build(string buildingName)
        {
            var typeOfBuilding = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(type => type.CustomAttributes.Any(a => a.AttributeType == typeof(BuildingAttribute)) &&
                                        type.Name.Equals(buildingName));

            if (typeOfBuilding == null)
            {
                throw new BuildingNotImplementedExcepton($"'{buildingName}' building is not implemented yet.");
            }

            var building = Activator.CreateInstance(typeOfBuilding) as IBuilding;

            return building;
        }
    }
}