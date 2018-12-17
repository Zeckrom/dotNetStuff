FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 64395
EXPOSE 44370

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Injection/Injection.csproj", "Injection/"]
RUN dotnet restore "Injection/Injection.csproj"
COPY . .
WORKDIR "/src/Injection"
RUN dotnet build "Injection.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Injection.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Injection.dll"]