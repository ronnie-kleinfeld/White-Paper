# list containers
docker ps
# list active containers
docker ps --all
# list active containers IDs
docker ps -aq

# create containr from image
docker container create hello-world:linux

# start container
docker container start id..

# show log
docker logs id..

# create-start-log con
tainr
docker run hello-world:linux

# build from Dockerfile
docker build -f name.Dockerfile -t image-name .
. to copy the files from the current directory

# run an image
docker run image-name
docker run -d image-name # does not attach the terminal to the server

# execute command on container
docker exec id.. command
docker exec id.. date
docker exec 51dcf9746f85 date

# open bash within the container
docker exec --interactive --tty id.. bash

# stop container
docker stop id..
docker stop -t 0 id.. # stop imidiatley

# remove container
docker rm id.. # remove if stopped
docker rm -f id.. # stop and remove

# remove with loop
docker ps -aq | xargs docker rm

# remove image
docker rmi id.. # remove if stopped
docker rmi -f id.. # stop and remove

# map port to http
docker run -d --name web-server web-server -p 5001:5000
http://localhost:5001
