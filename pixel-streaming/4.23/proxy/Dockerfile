FROM adamrehn/ue4-full:4.23.1-pixelstreaming as builder
FROM adamrehn/ue4-runtime:latest

# Copy the WebRTCProxy application from the Pixel Streaming builder image
COPY --from=builder --chown=ue4:ue4 /home/ue4/UnrealEngine/Engine/Source/Programs/PixelStreaming/WebRTCProxy/bin/WebRTCProxy /bin/WebRTCProxy

# Set the WebRTCProxy application as the container's entrypoint
ENTRYPOINT ["/bin/WebRTCProxy"]
