#r "packages/FAKE/tools/FakeLib.dll" // include Fake lib
open Fake 


Target "Test" (fun _ ->
    trace "Testing stuff..."
)

Target "Deploy" (fun _ ->
    trace "Heavy deploy action"
)

"Test"            // define the dependencies
   ==> "Deploy"

Run "Deploy"