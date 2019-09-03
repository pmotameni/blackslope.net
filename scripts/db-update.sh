cd ../src/BlackSlope.Api
dotnet ef database update -v 

cd ../BlackSlope.IdentityProvider
dotnet ef database update -v  --context ApplicationDbContext
dotnet ef database update -v  --context ConfigurationDbContext
dotnet ef database update -v  --context PersistedGrantDbContext