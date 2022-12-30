#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Poc.Mensageria.Kafka/Poc.Mensageria.Kafka.csproj", "Poc.Mensageria.Kafka/"]
RUN dotnet restore "Poc.Mensageria.Kafka/Poc.Mensageria.Kafka.csproj"
COPY . .
WORKDIR "/src/Poc.Mensageria.Kafka"
RUN dotnet build "Poc.Mensageria.Kafka.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Poc.Mensageria.Kafka.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Poc.Mensageria.Kafka.dll"]