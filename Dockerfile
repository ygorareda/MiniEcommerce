# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./src/MiniEcommerce.Api/MiniEcommerce.Api/csproj" --disable-parallel
RUN dotnet publish "./src/MiniEcommerce.Api/MiniEcommerce.Api/csproj" -c release -o /app --no-restore

# Serve Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-foca
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "MiniEcommerce.Api.dll"]
