#FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
#WORKDIR /src
#COPY ["Solution1/Solution1.csproj", "Solution1/"]
#RUN dotnet restore "Solution1/Solution1.csproj"
#COPY . .
#WORKDIR "/src/Solution1"
#RUN dotnet build "Solution1.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "Solution1.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Solution1.dll"]
