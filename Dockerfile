FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5001

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["CalcTest.API/CalcTest.API.csproj", "CalcTest.API/"]
RUN dotnet restore "CalcTest.API/CalcTest.API.csproj"
COPY . .
WORKDIR "/src/CalcTest.API"
RUN dotnet build "CalcTest.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CalcTest.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CalcTest.API.dll"]
