FROM adamrehn/ue4-full:4.24.3

# READ THIS:
RUN echo "NOTE: this example is provided as a Dockerfile simply because it makes it easy for users to test. \
          In actual use your CI/CD system would spin up a container and run these commands inside it, \
          since the end result is not actually a container image but simply packaged files."

# Copy the source code for our dummy Unreal project
COPY --chown=ue4:ue4 ./DummyProject /tmp/project

# Build our Unreal project
WORKDIR /tmp/project
RUN ue4 build

# Run any automation tests for our project
# (Note that the dummy project has no tests, so this step will always succeed)
RUN ue4 test --filter Product

# Cook the content for our project and package up a distributable build for users
RUN ue4 package

# READ THIS:
RUN echo "NOTE: the packaged files for the project are now stored in '/tmp/project/dist'. \
          In actual use you would then compress these files and copy them somewhere useful."
