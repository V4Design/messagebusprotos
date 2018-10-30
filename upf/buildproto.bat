@echo off
Pushd "%~dp0"

set PLUGINCSHARP="%PROTOTOOLS%grpc_csharp_plugin.exe"
set PLUGINCPP="D:\Github\vcpkg\packages\grpc_x64-windows\tools\grpc\grpc_cpp_plugin.exe"

set outdircsharp=(..\restingprotos\proto\)
set outdircpp=()

for %%f in (*.proto) do (
	for %%o in %outdircsharp% do (
		if %%o == "" (
			call protoc -I=%%~df%%~pf --csharp_out=%%~df%%~pf %%~df%%~pf%%f --grpc_out=%%~df%%~pf --plugin=protoc-gen-grpc=%PLUGINCSHARP%
		) else (
			call protoc -I=%%~df%%~pf --csharp_out=%%o %%f --grpc_out=%%o --plugin=protoc-gen-grpc=%PLUGINCSHARP%
		)
	)	
	for %%o in %outdircpp% do (
		if %%o == "" (
			call protoc -I=%%~df%%~pf --cpp_out=%%~df%%~pf %%~df%%~pf%%f --grpc_out=%%~df%%~pf --plugin=protoc-gen-grpc=%PLUGINCPP%
		) else (
			call protoc -I=%%~df%%~pf --cpp_out=%%o %%f --grpc_out=%%o --plugin=protoc-gen-grpc=%PLUGINCPP%
		)
	)	
)