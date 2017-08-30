I use a command similar to this to run it via docker

`docker pull microsoft/dotnet:latest; docker run -v ``pwd``:/root/dotnet -it microsoft/dotnet:latest`

Then

`dotnet restore`

`dotnet test`

or

`dotnet watch test`

