FROM microsoft/aspnetcore:1.0.1
ENTRYPOINT ["dotnet", "ProjectEuler.dll"]
ARG source=bin/Debug/netcoreapp1.0/publish/
WORKDIR /app
EXPOSE 80
COPY $source .
