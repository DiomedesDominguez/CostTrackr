FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine as base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
WORKDIR /src
COPY Web/ Web/
RUN dotnet restore Web/DNMOFT.CostTrackr.Web.csproj
WORKDIR /src/GTM
RUN dotnet build DNMOFT.CostTrackr.Web.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish DNMOFT.CostTrackr.Web.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DNMOFT.CostTrackr.Web.dll"]

