// Learn more about F# at http://fsharp.org

open System

let rec length values =
    match values with
    | []      -> 0
    | e::rest -> 1 + length rest
    

let rec sum values =
    match values with
    | [] -> 0
    | e::rest -> e + sum rest


[<EntryPoint>]
let main argv =
    printf "filename> "
    let filename = System.Console.ReadLine()
    let data_array = System.IO.File.ReadAllLines(filename)
    let data_list= Array.toList data_array


    let values = List.map (fun s -> int s) data_list
    printfn "%A" values
    
    let len = length values
    printfn "%A" len
    let total = sum values
    printfn "%A" total
    0