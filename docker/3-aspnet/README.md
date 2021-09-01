# 3 - Containerize a asp.net core app.

## Create
- Visual studio > New project > Blazor server > Enable docker

## Build and run
### From the same folder as the sln file:
- docker build -t <name>:<tag> -f 
- docker run -d -p 8082:8080 aspnet-image:latest