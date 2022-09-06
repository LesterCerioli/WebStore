#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["source/WebAPIs/Core/WebStore.Services.Core.API/WebStore.Services.Core.API.csproj", "source/WebAPIs/Core/WebStore.Services.Core.API/"]
RUN dotnet restore "source/WebAPIs/Core/WebStore.Services.Core.API/WebStore.Services.Core.API.csproj"
COPY . .
WORKDIR "/src/source/WebAPIs/Core/WebStore.Services.Core.API"
RUN dotnet build "WebStore.Services.Core.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebStore.Services.Core.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebStore.Services.Core.API.dll"]