# v4dprotos

SEE http://136.144.207.251:8080/swagger/index.html

Contains all proto files used for internal service to service communication

.net core and c++ code is generated using the buildproto.bat script, which scans all .proto files in currect directory and executes the protoc application (check directory in .bat). For additional language support like javascript java python.. check grpc.io
protobuf & grpc can be build using vcpkg for c++ on windows. for .net nuget can be used.

