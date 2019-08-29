# Build the application
FROM microsoft/dotnet:2.2-sdk AS identityServerBuild
COPY . .
WORKDIR /
RUN dotnet restore
RUN dotnet publish --no-restore -c Release -o /app

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
EXPOSE 80
EXPOSE 443
WORKDIR /app
COPY --from=identityServerBuild /app .

ENTRYPOINT ["dotnet", "IdentityServer.dll"]
