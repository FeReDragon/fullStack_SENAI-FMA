FROM mcr.microsoft.com/dotnet/sdk:7.0 as build-env
WORKDIR /src
COPY src/ApiDocker/*.csproj ./ApiDocker/
RUN dotnet restore "/src/ApiDocker/ApiDocker.csproj" --use-current-runtime
COPY src/ApiDocker/ ./ApiDocker/
RUN dotnet publish "ApiDocker/ApiDockerSln.sln" -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0 as runtime
WORKDIR /publish
COPY --from=build-env /publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "ApiDocker.dll"]







