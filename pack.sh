dotnet nuget locals -c all
dotnet pack -c Release -t:Clean,Rebuild datadog-ios-binding.sln --output $PWD/nugets