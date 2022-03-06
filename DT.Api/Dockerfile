#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DT.Api/DT.Api.csproj", "DT.Api/"]
RUN dotnet restore "DT.Api/DT.Api.csproj"
COPY . .
WORKDIR "/src/DT.Api"
RUN dotnet build "DT.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DT.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DT.Api.dll"]