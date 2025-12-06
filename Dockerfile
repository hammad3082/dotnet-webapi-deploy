# --- Build stage ----------------------------------------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# copy csproj and restore first (helps cache)
COPY *.csproj ./
RUN dotnet restore

# copy everything and publish
COPY . .
RUN dotnet publish -c Release -o /app/publish

# --- Runtime stage --------------------------------------------------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# copy published output from build stage
COPY --from=build /app/publish .

# tell container to listen on 8080 (convention)
EXPOSE 8080

# run the app (dll name = project name)
ENTRYPOINT ["dotnet", "dotnet-webapi-deploy.dll"]