#
# The build image
#
FROM microsoft/aspnetcore-build:2 AS build

WORKDIR /src

COPY . .

RUN dotnet restore

RUN dotnet publish --output /app/ --configuration Release

#
# The deployment image
#
FROM microsoft/aspnetcore:2

COPY --from=build /app /app/

WORKDIR /app

ENTRYPOINT ["dotnet", "DockerDemo.dll"]

