Nginx Configuration

upstream coreapp {
    server localhost:5000;
    server localhost:5001;
    server localhost:5002;
}
server {
    listen 80;
 
        location / {
            proxy_pass http://coreapp;
        }
}

Jenkins Shell Commands

cd CoreApp.Tests && dotnet test
cd ../CoreApp.Web/
sudo docker-compose down
sudo docker build -t coreapp .
sudo docker-compose up -d
