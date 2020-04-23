FROM adamrehn/ue4-full:4.24.3

# READ THIS:
RUN echo "NOTE: this example is provided as a Dockerfile simply because it makes it easy for users to test. \
          In actual use your CI/CD system would spin up a container and run these commands inside it, \
          since the end result is not actually a container image but simply packaged files."

# Copy the source code for our dummy Unreal plugin
COPY --chown=ue4:ue4 ./DummyPlugin /tmp/plugin

# Build and package our plugin for distribution (e.g. via the Unreal Marketplace)
WORKDIR /tmp/plugin
RUN ue4 package

# READ THIS:
RUN echo "NOTE: the packaged files for the plugin are now stored in '/tmp/plugin/dist'. \
          In actual use you would then compress these files and copy them somewhere useful."
