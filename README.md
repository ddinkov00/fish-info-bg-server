# Fish Info BG

### _General_

1. Add package - dotnet add package <NAME>

### _Server_

1. Swagger - http://localhost:5255/swagger/index.html

### _Database_

1. Add migration - dotnet ef migrations add Identity -p ./data.csproj -s ../server/server.csproj
2. Update - dotnet ef database update -p ./data.csproj -s ../server/server.csproj
