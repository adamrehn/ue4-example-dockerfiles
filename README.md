# Example Dockerfiles for using Unreal Engine containers

This repository contains a number of example Dockerfiles that demonstrate various uses of Unreal Engine containers. For more details, see the documentation on the [Unreal Containers community hub](https://unrealcontainers.com).

**Note: these Dockerfiles are provided as informative examples only and come with no guarantees regarding their suitability for production use.**

The example Dockerfiles are grouped in subdirectories according to use case:

- [`dedicated-servers`](./dedicated-servers): examples for packaging dedicated servers for Unreal projects.

- [`pixel-streaming`](./pixel-streaming): examples for packaging Unreal projects that use [Pixel Streaming for Linux](https://adamrehn.com/articles/pixel-streaming-in-linux-containers/), grouped by Unreal Engine version.

- [`plugins`](./plugins): examples for building and packaging Unreal plugins. *(Note that these examples are provided as Dockerfiles simply because it makes them easy for users to test. In actual use your CI/CD system would spin up a container and run the commands inside it, since the end result is not actually a container image but simply packaged files.)*

- [`projects`](./projects): examples for building, testing and packaging Unreal projects. *(Note that these examples are provided as Dockerfiles simply because it makes them easy for users to test. In actual use your CI/CD system would spin up a container and run the commands inside it, since the end result is not actually a container image but simply packaged files.)*
