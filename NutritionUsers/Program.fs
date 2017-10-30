// Learn more about F# at http://fsharp.org

open System
open Generator.Users

let generate n =
  createUser (n) |> (List.map (fun u -> (printfn "%s %i %f %f" u.firstName u.age u.height u.weight)))
  0

let errorCase t =
  printfn t
  1

[<EntryPoint>] 
let main argv = 
  if argv.Length = 0 then errorCase "Please provide a number"
  elif (int(argv.[0]) < 1) then errorCase "Please provide a number of users greater than 0"
  else generate (int(argv.[0]))
