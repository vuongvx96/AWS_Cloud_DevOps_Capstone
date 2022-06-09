#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY GloboTicket.TicketManagement.App.csproj .
RUN dotnet restore GloboTicket.TicketManagement.App.csproj
COPY . .
RUN dotnet build GloboTicket.TicketManagement.App.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish GloboTicket.TicketManagement.App.csproj -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
ENV ASPNETCORE_ENVIRONMENT Production
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf