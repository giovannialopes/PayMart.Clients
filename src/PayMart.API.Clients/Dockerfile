FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

COPY ./PayMart.Domain.Clients/PayMart.Domain.Clients.csproj ./PayMart.Domain.Clients/
COPY ./PayMart.Infrastructure.Clients/PayMart.Infrastructure.Clients.csproj ./PayMart.Infrastructure.Clients/
COPY ./PayMart.API.Clients/PayMart.API.Clients.csproj ./PayMart.API.Clients/
RUN dotnet restore ./PayMart.API.Clients/PayMart.API.Clients.csproj

COPY ./PayMart.Domain.Clients ./PayMart.Domain.Clients/
COPY ./PayMart.Infrastructure.Clients ./PayMart.Infrastructure.Clients/
COPY ./PayMart.API.Clients ./PayMart.API.Clients/

WORKDIR /app/PayMart.API.Clients
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/PayMart.API.Clients/out .

EXPOSE 5001

ENTRYPOINT ["dotnet", "PayMart.API.Clients.dll"]
