FROM adamrehn/ue4-full:4.24.3 AS builder

# Copy the source code for our dummy Unreal project
COPY --chown=ue4:ue4 ./DummyProject /tmp/project

# Build and package the dedicated server for our Unreal project
WORKDIR /tmp/project
RUN ue4 package Shipping -server -noclient

# Copy the packaged files into a runtime container image that doesn't include any Unreal Engine components
FROM adamrehn/ue4-runtime:latest
COPY --from=builder --chown=ue4:ue4 /tmp/project/dist/LinuxServer /home/ue4/project

# Expose the ports that the dedicated server listens on
EXPOSE 7777

# Set the packaged server as the container's entrypoint
ENTRYPOINT ["/home/ue4/project/DummyProjectServer.sh"]
