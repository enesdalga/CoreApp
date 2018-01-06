FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /app


COPY *.csproj ./
RUN dotnet restore


COPY . ./
RUN dotnet publish -c Release -o output


FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build /app/output .

EXPOSE 5000
ENV ASPNETCORE_URLS http://*:5000
ENV ASPNETCORE_ENVIRONMENT docker

ENTRYPOINT ["dotnet", "CoreApp.Web.dll"]