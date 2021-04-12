FROM microsoft/aspnetcore-build:2.0
WORKDIR /app
COPY . .
RUN donet build -c Release
ENTRYPOINT ["dotnet","run","--no-launch-profile"]