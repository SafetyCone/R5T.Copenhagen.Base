using System;

using R5T.T0064;


namespace R5T.Copenhagen
{
    [ServiceDefinitionMarker]
    public interface ICDrivePathProvider : IServiceDefinition
    {
        string GetCDrivePath();
    }
}
