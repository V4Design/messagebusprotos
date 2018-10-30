FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
COPY ["v4demo_simulation_rest/eiffel tower.txt","eiffel tower.txt"]
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["v4demo_simulation_rest/v4demo_simulation_rest.csproj", "v4demo_simulation_rest/"]
RUN dotnet restore "v4demo_simulation_rest/v4demo_simulation_rest.csproj"
COPY . .
WORKDIR "/src/v4demo_simulation_rest"
RUN dotnet build "v4demo_simulation_rest.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "v4demo_simulation_rest.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "v4demo_simulation_rest.dll"]