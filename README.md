# About the repository
Containerize Dotnet 6 Console application with Docker using Dockerfile

# Run the project
## With Docker
To run the app with docker, please make sure that docker already installed in the machine, and then follow the following steps:
* Navigate to `DotNet6ConsoleApp/Program.cs` 
* `docker build -t dotent6consoleapp:v1.0 .` to build new image based on *Dockerfile*
* `docker images -a` to check the existence of `dotent6consoleapp:v1.0` image
* `docker run -ti dotent6consoleapp:v1.0` to run the created image in a container

## Without Docker
To run the project without docker, the host machine where to run it should be prepared with:
* [Dotnet 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* [DOtnet 6 runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

Navigate to `DotNet6ConsoleApp/Program.cs` then `dotnet run`

# References
* [Tutorial: Containerize a .NET app](https://docs.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=linux)
