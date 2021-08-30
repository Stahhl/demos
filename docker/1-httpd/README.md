[https://hub.docker.com/_/httpd](httpd on docker hub)

# Version 1

1. Changes:
..* index.html
   ```html 
    <h1>Hello World</h1>

    <p>Version 1</p>
    ```
1. Build and run
..* docker build -t httpd-image:v1 .
..* docker run -d --name httpd-container-1 -p 8080:80 httpd-image:v1

# Version 2

1. Changes:
..* index.html
    ```html
    <p>Version 2</p>
    ```
..* Dockerfile
    ```Dockerfile
    FROM httpd:2.4-alpine
    ```
2. Build and run
..* docker build -t httpd-image:v2 .
..* docker run -d --name httpd-container-2 -p 8081:80 httpd-image:v1