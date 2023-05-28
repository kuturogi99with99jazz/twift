FROM mcr.microsoft.com/dotnet/sdk:7.0

WORKDIR /twift

RUN mkdir src

COPY ./src /src/

ENV ConnectionStrings__DefaultConnection "Server=twiftdb;Port=5432;User Id=postgres;Password=postgres;Database=postgres"

# CMD [ "bash" ]
CMD [ "dotnet", "watch", "run", "--project", "/src/src.csproj", "--urls", "http://*:5062" ]
