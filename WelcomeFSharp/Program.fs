open System

[<EntryPoint>]
let main _argv = 
    printfn "Hello and Welcome to F#!"
    printf "Please tell me your name: "
    let name = Console.ReadLine()
    printfn "Hello, %s!" name
    Console.ReadLine() |> ignore
    0