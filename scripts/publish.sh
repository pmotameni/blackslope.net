rm -r ../publish
dotnet publish ../src/blackslope.api/blackslope.api.csproj --configuration RELEASE --output ../../publish

dotnet publish ../src/BlackSlope.IdentityProvider/IdentityServer.csproj --configuration RELEASE --output ../../publish
