FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app

COPY *.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

WORKDIR /app/out
CMD dotnet a1.dll
