#Dockerfile
# FROM linux
FROM node:alpine

#copy files from current directory to app folder in the docker
COPY . /app

# set work directory
WORKDIR /app

# execute a command
CMD node app.js
# CMD node /app.js

# docker
# build an image
# build         build the Dockerfile
# -t name       container name / tag
# .             specify the current directory to copy files from
#docker build -t hello-node-docker .

# list of images
#docker image ls

# run an image
#docker run hello-node-docker