FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["ecommerce-uni/ecommerce-uni.csproj", "ecommerce-uni/"]
RUN dotnet restore "ecommerce-uni/ecommerce-uni.csproj"
COPY . .
WORKDIR "/src/ecommerce-uni"
RUN dotnet publish "ecommerce-uni.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "ecommerce-uni.dll"]
