[![Mark Henry](https://img.shields.io/static/v1?label=Author&message=Mark%20Henry&color=success)](https://www.linkedin.com/in/marknhenry/) 
[![License](https://img.shields.io/static/v1?label=License&message=MIT&color=blue)](https://www.linkedin.com/in/marknhenry/)

# blzr-advanced-intro

## First time Setup of Container: 
``` bash 
docker stop razorbase # stop container
docker rm razorbase # remove container
docker build -t "razor-base-env:v1" . # Build the image from Dockerfile
docker run -it -p 8888:8888 -d --name razorbase "razor-base-env:v1" # Run container
docker exec -it razorbase /bin/bash # Log into container
```

## Cloning the repo locally in container: 

``` bash
gh auth login
git config --global user.email "marknhenry@live.com"
git config --global user.name "Mark Henry"
gh repo clone marknhenry/blzr-advanced-intro
```

## Create the new Blazor App


## Running Jupyter
``` bash
jupyter notebook --ip 0.0.0.0 --no-browser --allow-root
# Use the link provided
```

## Updating work on main

``` bash
git pull origin
git add .
git commit -m "message"
git push origin
```
