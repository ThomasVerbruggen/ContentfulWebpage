FROM mcr.microsoft.com/dotnet/sdk:3.1

WORKDIR /app

COPY . .

EXPOSE 5000

ENTRYPOINT ["dotnet", "run"]