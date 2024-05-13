#Server#

1. Swagger - http://localhost:5255/swagger/index.html

#Database#

1. Add migration - dotnet ef migrations add <NAME> -p ./data.csproj -s ../server/server.csproj
2. Update - dotnet ef database update -p ./data.csproj -s ../server/server.csproj
