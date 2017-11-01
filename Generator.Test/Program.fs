// Learn more about F# at http://fsharp.org

open System
open Expecto
//open Expecto.FsCheck
open Generator.Users


[<Tests>]
let testNumberOfUsers =
    testProperty "number of generated users matches given argument if > 0 and 0 otherwise" <| fun (n: int) -> 
    (createUser n |> List.length) = if n > 0 then n
                                    else 0

[<Tests>]
let testUserParameters =
    testProperty "generated User has height, weight, age and name" <|fun x ->
    let athlete = createUser 1
    athlete.[0].height > 0.0 &&
    athlete.[0].weight > 0.0 &&
    athlete.[0].age > 0 &&
    athlete.[0].firstName.Length > 0 


[<EntryPoint>]
let main argv = 
    runTestsInAssembly defaultConfig argv