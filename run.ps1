$ErrorActionPreference = "Stop"
# restore fake from nuget
&".\nuget.exe" "Install" "FAKE" "-OutputDirectory" "packages" "-ExcludeVersion"
# and build using fake
&".\packages\FAKE\tools\Fake.exe" "build.fsx" 2>&1 > out.txt