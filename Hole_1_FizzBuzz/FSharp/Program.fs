open System

[<EntryPoint>]
let main argv =
    [1..100] 
    |> Seq.map(fun i -> 
        match i%3=0, i%5=0 with
        | true, true -> "FizzBuzz"
        | true, false -> "Fizz"
        | false, true -> "Buzz"
        | _ -> i.ToString();
    )
    |> Seq.iter (printfn "%s")
    0
