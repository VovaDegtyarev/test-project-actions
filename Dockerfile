FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
EXPOSE 80
WORKDIR /app

COPY ["/WebAppSolution.sln", "./"]
COPY ["/WebApp.Api/WebApp.Api.csproj", "WebApp.Api/"]
COPY ["/WebApp.BL/WebApp.BL.csproj", "WebApp.BL/"]
COPY ["/WebApp.DAL/WebApp.DAL.csproj", "WebApp.DAL/"]

RUN dotnet restore WebAppSolution.sln

COPY ["WebApp.Api/", "./WebApp.Api/"]
COPY ["WebApp.BL/", "./WebApp.BL/"]
COPY ["WebApp.DAL/", "./WebApp.DAL/"]

WORKDIR /app
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime

WORKDIR /app

COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "WebApp.Api.dll"]