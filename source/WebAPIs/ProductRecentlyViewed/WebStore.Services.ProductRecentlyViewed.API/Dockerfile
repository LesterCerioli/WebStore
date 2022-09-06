#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["source/WebAPIs/ProductRecentlyViewed/WebStore.Services.ProductRecentlyViewed.API/WebStore.Services.ProductRecentlyViewed.API.csproj", "source/WebAPIs/ProductRecentlyViewed/WebStore.Services.ProductRecentlyViewed.API/"]
RUN dotnet restore "source/WebAPIs/ProductRecentlyViewed/WebStore.Services.ProductRecentlyViewed.API/WebStore.Services.ProductRecentlyViewed.API.csproj"
COPY . .
WORKDIR "/src/source/WebAPIs/ProductRecentlyViewed/WebStore.Services.ProductRecentlyViewed.API"
RUN dotnet build "WebStore.Services.ProductRecentlyViewed.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebStore.Services.ProductRecentlyViewed.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebStore.Services.ProductRecentlyViewed.API.dll"]