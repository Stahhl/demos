1. Visual studio > New project > Blazor server > Enable docker
2. Changes:
- Dockerfile
    ```
    EXPOSE 8080
    ENV ASPNETCORE_URLS=http://+:8080
    ```
- Pages\index.razor
    ```html
    Something
    ```
1. Build and run
- docker build -t aspnet-image:latest -f 
- docker run -d -p 8082:8080 aspnet-image:latest