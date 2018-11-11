FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 61041
EXPOSE 44390

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["WebApiCoreTest/WebApiCoreTest.csproj", "WebApiCoreTest/"]
RUN dotnet restore "WebApiCoreTest/WebApiCoreTest.csproj"
COPY . .
WORKDIR "/src/WebApiCoreTest"
RUN dotnet build "WebApiCoreTest.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WebApiCoreTest.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebApiCoreTest.dll"]