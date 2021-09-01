# 3 - Containerize a asp.net core app.

## Create
Visual studio > New project > Blazor server > Enable docker

## Build and run
From the same folder as the sln file:
```
docker build -t <image>:<tag> -f <project>\Dockerfile .
docker run -d -p <port>:8080 <image>:<tag>
```