FROM adamrehn/ue4-full:4.23.1-pixelstreaming as builder
FROM node:10

# Copy the signalling server from the Pixel Streaming builder image
COPY --from=builder home/ue4/UnrealEngine/Engine/Source/Programs/PixelStreaming/WebServers/SignallingWebServer /opt/SignallingWebServer

# Install the dependencies for the signalling server
WORKDIR /opt/SignallingWebServer
RUN npm install .

# Expose TCP port 80 so external applications can access the web server
EXPOSE 80

# Set the signalling server as the container's entrypoint
ENTRYPOINT ["/usr/local/bin/node", "/opt/SignallingWebServer/cirrus.js"]
