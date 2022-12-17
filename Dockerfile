FROM mcr.microsoft.com/dotnet/sdk:3.1.426-alpine3.16 AS build

WORKDIR /source

COPY MusicianList.csproj ./app/
RUN dotnet restore app

COPY . ./app/
WORKDIR /source/app
RUN dotnet publish -c Release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:3.1.32-alpine3.16
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "MusicianList.dll"]