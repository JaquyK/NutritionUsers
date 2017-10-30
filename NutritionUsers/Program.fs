// Learn more about F# at http://fsharp.org

open System
open Generator.Users


[<EntryPoint>] 
let main argv = 
    (createUser (int(argv.[0]))) |> List.map (fun u -> printfn "%s %i %f %f" u.firstName u.age u.height u.weight)
    1
  