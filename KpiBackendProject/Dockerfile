FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["KpiBackendProject/KpiBackendProject.csproj", "KpiBackendProject/"]
RUN dotnet restore "KpiBackendProject/KpiBackendProject.csproj"
COPY . .
WORKDIR "/src/KpiBackendProject"
RUN dotnet build "KpiBackendProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KpiBackendProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KpiBackendProject.dll"]
