// Learn more about F# at http://fsharp.org

open System
open MathNet.Numerics.Statistics;
open MathNet.Numerics.Distributions;

type Athlete = {firstName : string; age : int; height : double; weight : double }

let names = [|"Bob";"Ali";"Lisa";"Peter";"Hanna";"Anna";"James";"Jennifer";"Sarah";"Max";"Hugo"|]

let a = Normal.Sample(30.00,4.00)

let genUser _ = {firstName = names.[System.Random().Next(0,10)]; age = int(Normal.Sample(30.00,4.00)); height = Normal.Sample(175.00 , 5.0); weight = Normal.Sample(75.00,5.00)}  
let createUser n =
  [1..n] |> List.map genUser
  


[<EntryPoint>] 
let main argv = 
    (createUser (int(argv.[0]))) |> List.map (fun u -> printfn "%s %i %f %f" u.firstName u.age u.height u.weight)
    1
  