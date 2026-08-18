FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Liventi.Api/Liventi.Api.csproj", "src/Liventi.Api/"]
COPY ["src/Liventi.Application/Liventi.Application.csproj", "src/Liventi.Application/"]
COPY ["src/Liventi.Domain/Liventi.Domain.csproj", "src/Liventi.Domain/"]
COPY ["src/Liventi.Infrastructure/Liventi.Infrastructure.csproj", "src/Liventi.Infrastructure/"]
RUN dotnet restore "./src/Liventi.Api/./Liventi.Api.csproj"
COPY . .
WORKDIR "/src/src/Liventi.Api"
RUN dotnet build "./Liventi.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Liventi.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Liventi.Api.dll"]