# Perform the build in an Unreal Engine container image that includes the Engine Tools and Linux support for Pixel Streaming
FROM adamrehn/ue4-full:4.23.1-pixelstreaming AS builder

# Copy the source code for our dummy Unreal project
COPY --chown=ue4:ue4 ./DummyProject /tmp/project

# Build and package our Unreal project
WORKDIR /tmp/project
RUN ue4 package

# Copy the packaged files into a runtime container image that doesn't include any Unreal Engine components
FROM adamrehn/ue4-runtime:latest
COPY --from=builder --chown=ue4:ue4 /tmp/project/dist/LinuxNoEditor /home/ue4/project

# Enable the NVIDIA driver capabilities required by the NVENC API
ENV NVIDIA_DRIVER_CAPABILITIES ${NVIDIA_DRIVER_CAPABILITIES},video

# Create a symbolic link to the path where libnvidia-encode.so.1 will be mounted, since UE4 seems to ignore LD_LIBRARY_PATH
RUN ln -s /usr/lib/x86_64-linux-gnu/libnvidia-encode.so.1 /home/ue4/project/DummyProject/Binaries/Linux/libnvidia-encode.so.1

# Set the packaged project as the container's entrypoint
ENTRYPOINT ["/home/ue4/project/DummyProject.sh", "-AudioMixer", "-opengl4"]
