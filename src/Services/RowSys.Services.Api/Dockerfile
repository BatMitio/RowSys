FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Services/RowSys.Services.Api/RowSys.Services.Api.csproj", "RowSys.Services.Api/"]
RUN dotnet restore "src/Services/RowSys.Services.Api/RowSys.Services.Api.csproj"
COPY . .
WORKDIR "/src/RowSys.Services.Api"
RUN dotnet build "RowSys.Services.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RowSys.Services.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RowSys.Services.Api.dll"]
