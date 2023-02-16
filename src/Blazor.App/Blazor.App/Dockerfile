#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Blazor.App/Blazor.App.csproj", "Blazor.App/"]
RUN dotnet restore "Blazor.App/Blazor.App.csproj"
COPY . .
WORKDIR "/src/Blazor.App"
RUN dotnet build "Blazor.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blazor.App.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blazor.App.dll"]