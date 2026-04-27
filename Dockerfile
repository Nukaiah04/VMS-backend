FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
COPY VMS/VMS.csproj ./VMS/
RUN dotnet restore ./VMS/VMS.csproj
COPY . .
WORKDIR /app/VMS
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/VMS/out .
EXPOSE 80
ENTRYPOINT ["dotnet", "VMS.dll"]