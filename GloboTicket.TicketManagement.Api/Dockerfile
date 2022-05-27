#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GloboTicket.TicketManagement.Api/GloboTicket.TicketManagement.Api.csproj", "GloboTicket.TicketManagement.Api/"]
COPY ["GloboTicket.TicketManagement.Infrastructure/GloboTicket.TicketManagement.Infrastructure.csproj", "GloboTicket.TicketManagement.Infrastructure/"]
COPY ["GloboTicket.TicketManagement.Application/GloboTicket.TicketManagement.Application.csproj", "GloboTicket.TicketManagement.Application/"]
COPY ["GloboTicket.TicketManagement.Domain/GloboTicket.TicketManagement.Domain.csproj", "GloboTicket.TicketManagement.Domain/"]
COPY ["GloboTicket.TicketManagement.Identity/GloboTicket.TicketManagement.Identity.csproj", "GloboTicket.TicketManagement.Identity/"]
COPY ["GloboTicket.TicketManagement.Persistence/GloboTicket.TicketManagement.Persistence.csproj", "GloboTicket.TicketManagement.Persistence/"]
RUN dotnet restore "GloboTicket.TicketManagement.Api/GloboTicket.TicketManagement.Api.csproj"
COPY . .
WORKDIR "/src/GloboTicket.TicketManagement.Api"
RUN dotnet build "GloboTicket.TicketManagement.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GloboTicket.TicketManagement.Api.csproj" -c Release -o /app/publish

FROM base AS finalcd
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GloboTicket.TicketManagement.Api.dll"]